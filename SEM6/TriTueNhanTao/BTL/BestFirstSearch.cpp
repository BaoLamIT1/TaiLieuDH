#define pi pair<int, string>
#define pii pair<int, pi>
#define piii pair<int, pi>
#define piiii pair<int, piii>
#include<iostream>
#include<bits/stdc++.h>
	using namespace std;
priority_queue<pi, vector<pi>, greater<pi>> Q;
priority_queue<pi, vector<pi>, greater<pi>> temp;
map<string, int> visit;		//danh sach da tham
map<pi, vector<pi>> graph;	// danh sach ke
map<string, string> revert;	//bat dau va ket thuc
string start, stop;
int BestFirstSearch(string root, int a){  // đầu vào là đỉnh gốc(root) và a
	Q.push(make_pair(a,root));	// push(a,root) vao hang doi Q
	visit[root] = 1;         // đánh dấu root đã đi qua và đặt giá trị là 1 
	
	while(!Q.empty()){
		pi x = Q.top();
		Q.pop();
		cout << setw(10) << x.second << "-" << to_string(x.first) << setw(8) << " |";
		if(x.second == stop){    // neu dinh x cua phan tu vua dc lay ra bang voi dinh stop -> den dich -> found
			cout << "\n found \n";
			return 1;
		}		
		string str = "";  // chuỗi lưu trữ đỉnh kề
		for(auto i: graph[x]){
			str += " " + i.second + "-" + to_string(i.first) + " ";
			if(visit.find(i.second) == visit.end()){ // kiem tra xem dinh tiep theo da duoc visit hay chua 
				revert[i.second] = x.second;		// neu chua duoc visit thi them vao hang doi roi dua dinh ke cua no vao 	
				Q.push(i);							// hang doi tiep theo de xet trong vong lap tiep 
				visit[i.second] = 1;
			}
		}
		cout << str << setw(42 - str.size()) << " |";
		temp = Q;
		while(!temp.empty()){
			cout << temp.top().second << "-" << temp.top().first << " ";	// in ra chuoi string va cac phan tu trong hang doi
			temp.pop();
		}
		cout << endl;
	}
	return 0;
}
void printPath(string des){   // Input là đỉnh đích(des)
//	cout << revert[des] << (revert[des]== start?" " : " <- ");  // kiểm tra xem đỉnh trước đó của des có tồn tại trong revert hay k 
//	while(revert.find(revert[des]) != revert.end()){   
//		printPath(revert[des]);  // nếu có gọi đệ quy printpath và đỉnh trước đó là đích
//		return;
//	}
if (revert.find(des) != revert.end()) {
        printPath(revert[des]);
        cout << " -> ";
    }
    cout << des;
}
void solve(){
int n;  // Nhap so dinh 
	cin >> n;
	cout<<setw(20)<<"Phat trien trang thai"<<setw(20)<<"Trang thai ke"<<setw(40)<<"Danh Sach L"<<endl;
	cout<<"=================================================================================="<<endl;
	for(int i = 0; i < n ; i++){
		int a, c; // a la so canh ke , c la trong so
		string b; // b la ten dinh
		cin >> a >> b >> c;
		for(int j = 0; j < a; j++){
			string x; // x la ten dinh ke ben danh sach L
			int d; // d la trong so 
			cin >> x >> d;
			graph[make_pair(c, b)].push_back(make_pair(d, x)); // danh sach ke cua moi dinh voi dinh va trong so
		}		
	}
	cin >> start >> stop;
	int found = BestFirstSearch(start, 20); // Goi ham BFS voi dinh bat dau là A va trong so bang 20
	// c1 in xuoi
	if (found == 1) {
		    cout << "Found: ";
		    printPath(stop);
		    cout << endl;
		} else {
		    cout << "Not Found" << endl;
		}
		
// C2: In nguoc
//	if(found){
//		cout << stop << " <- ";	
//		printPath(stop);
//	}else{
//		cout << "Not Found";
//	}
}
      
int main() {
	freopen("input_BestFirstSearch.txt", "r", stdin);
	freopen("output_BestFirstSearch.txt", "w", stdout);
	solve();
	return 0;

}
