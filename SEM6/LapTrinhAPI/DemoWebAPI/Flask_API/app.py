import flask
import pyodbc
from flask_cors import CORS
app=flask.Flask(__name__)
CORS(app)
str_connect='DRIVER={ODBC Driver 17 for SQL Server};SERVER=LAMVU\SQLEXPRESS;DATABASE=DuLieu;Trusted_Connection=yes;'
conn=pyodbc.connect(str_connect, timeout=30)

@app.route("/product/getAll",methods=['GET'])
def getAllProduct():
    try:
        cursor=conn.cursor()
        cursor.execute("SELECT * FROM tblSanPham join tblChatLieu on tblSanPham.ChatLieu = tblChatLieu.MaCL")
        result=[]
        keys=[]
        for i in cursor.description:
            keys.append(i[0])
        for val in cursor.fetchall():
            result.append(dict(zip(keys,val)))
        resp=flask.jsonify(result)
        resp.status_code=200
        return resp
    except Exception as e:
        print(e)


@app.route("/product/getByName",methods=['GET'])
def getSanPhamTheoTen():
    param1 = flask.request.args.get('tensp')
    param2 = flask.request.args.get('tencl')
    try:
        cursor=conn.cursor()
        cursor.execute("SELECT MaSP,TenSP,TenCL,MoTa,GiaNhap,GiaBan,Soluong FROM tblSanPham JOIN tblChatLieu ON tblSanPham.ChatLieu=tblChatLieu.MaCL WHERE TenSP LIKE ? AND TenCL LIKE ?",('%'+param1+'%','%'+param2+'%'))
        result=[]
        keys=[]
        for i in cursor.description:
            keys.append(i[0])
        for val in cursor.fetchall():
            result.append(dict(zip(keys,val)))
        resp=flask.jsonify(result)
        resp.status_code=200
        return resp
    except Exception as e:
        print(e)

@app.route("/product/getInventory",methods=['GET'])
def getSanPhamTonKho():
    try:
        cursor=conn.cursor()
        cursor.execute("SELECT * FROM tblSanPham WHERE Soluong>0")
        result=[]
        keys=[]
        for i in cursor.description:
            keys.append(i[0])
        for val in cursor.fetchall():
            result.append(dict(zip(keys,val)))
        resp=flask.jsonify(result)
        resp.status_code=200
        return resp
    except Exception as e:
        print(e)
@app.route("/product/getAllMaterial",methods=['GET'])
def getAllMaterial():
    try:
        cursor=conn.cursor()
        cursor.execute("SELECT * FROM tblChatLieu")
        result=[]
        keys=[]
        for i in cursor.description:
            keys.append(i[0])
        for val in cursor.fetchall():
            result.append(dict(zip(keys,val)))
        resp=flask.jsonify(result)
        resp.status_code=200
        return resp
    except Exception as e:
        print(e)
@app.route("/product/addProduct",methods=['POST'])
def addCustomer():
    try:
        masp=flask.request.json.get("MaSP")
        tensp=flask.request.json.get("TenSP")
        cl=flask.request.json.get("ChatLieu")
        mt=flask.request.json.get("MoTa")
        gn=flask.request.json.get("GiaNhap")
        gb=flask.request.json.get("GiaBan")
        sl = flask.request.json.get("Soluong")
        data=(masp,tensp,cl,mt,gn,gb,sl)
        sql_insert="INSERT INTO tblSanPham VALUES(?,?,?,?,?,?,?)"
        cursor=conn.cursor()
        cursor.execute(sql_insert,data)
        resp=flask.jsonify({"message":"Add Product Successfully"})
        resp.status_code=200
        return resp
    except Exception as e:
        print(e)

@app.route("/product/update", methods=['PUT'])
def updateSanPham():
    try:
        masp = flask.request.json.get("MaSP")
        tensp = flask.request.json.get("TenSP")
        cl = flask.request.json.get("ChatLieu")
        mt = flask.request.json.get("MoTa")
        gn = flask.request.json.get("GiaNhap")
        gb = flask.request.json.get("GiaBan")
        sl = flask.request.json.get("Soluong")
        data = (tensp, cl, mt, gn, gb, sl ,masp)
        cursor = conn.cursor()
        sql = "UPDATE tblSanPham SET TenSP = ?, ChatLieu= ?, MoTa = ?, GiaNhap = ?, GiaBan = ?, Soluong = ? WHERE MaSP = ?"
        cursor.execute(sql, data)
        conn.commit()
        resp = flask.jsonify({"message": "Updated Product Successfully"})
        resp.status_code = 200
        return resp
    except Exception as e:
        print(e)

@app.route("/product/delete/<int:id>", methods=['DELETE'])
def deleteSanPham(id):
    try:
        cursor = conn.cursor()
        sql = "DELETE FROM tblSanPham WHERE MaSP = ?"
        cursor.execute(sql, id)
        conn.commit()
        resp = flask.jsonify({"message": "Deleted Product Successfully"})
        resp.status_code = 200
        return resp
    except Exception as e:
        print(e)


if __name__ == '__main__':
    CORS(app, origins='http://localhost:5102')
    app.run(host='192.168.56.1', port=5000, debug=True)