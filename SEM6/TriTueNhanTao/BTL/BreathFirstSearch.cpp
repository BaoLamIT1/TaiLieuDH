#include<bits/stdc++.h>
using namespace std;
queue<string> Q;//hang doi 
queue<string> temp;//danh sach L
map<string, int> visit;//danh sach da tham
map<string, vector<string> > graph;// danh sach ke
map<string, string> revert;// lưu trữ trạng thái ban đầu và trạng thái hiện tại
string start, stop;//dinh bat dau va ket thuc cua do thi
int n;
int BFS(string root){
	Q.push(root); //Đưa đỉnh root vào hàng đợi Q và đánh dấu root đã được duyệt trong visit.
	visit[root] = 1;
	while(!Q.empty()){
		string x = Q.front();
		Q.pop();
		cout << setw(10) << x << setw(10) << " |";
		if(x == stop){//da den diem can tim
			cout << "\n found \n";
			return 1;
		}
		string str = "";
		for(auto i: graph[x]){//tim trong danh sach ke cua dinh do
			str += " " + i + " ";
			if(visit.find(i) == visit.end()){// kiem tra xem dinh tiep theo da duoc visit hay chua 
				revert[i] = x;//xac dinh diem dan den i la x
				Q.push(i);
				visit[i] = 1;				}
		}
		cout << str << setw(22 - str.size()) << " |";
		temp = Q;
		while(!temp.empty()){
			cout << temp.front().c_str() << " ";
			temp.pop();
		}
		cout << endl;
	}
	return 0;
}
void printPath(string des) {
    if (revert.find(des) != revert.end()) {
        printPath(revert[des]);
        cout << " -> ";
    }
    cout << des;
}
void solve(){
	cin >> n; // So dinh
	for(int i = 0; i < n ; i++){
		int a;//a la so canh ke, c la trong so
		string b;//b la ten dinh
		cin >> a >> b;
		for(int j = 0; j < a; j++){
			string x; //x la dinh ke
			// d la trong so, e la do dai canh
			cin >> x;
			graph[b].push_back(x);// graph la danh sach ke cua moi dinh
		}		
	}
	cin >> start >> stop;
	cout<<setw(20)<<"Phat trien trang thai"<<setw(20)<<"Trang thai ke"<<setw(20)<<"Danh Sach L"<<endl;
	cout<<"=================================================================================="<<endl;
	int found = BFS(start);
	// ...
	if (found == 1) {
	    cout << "Found: ";
	    printPath(stop);
	    cout << endl;
	} else {
	    cout << "Not Found" << endl;
	}
}
int main(){
	freopen("input_BreathFirstSearch.txt", "r", stdin);
	freopen("output_BreathFirstSearch.txt", "w", stdout);
	solve();
	return 0;
}

