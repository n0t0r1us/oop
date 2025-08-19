// code by duongdinh24.com
//github: https://github.com/duongdinh24/

#include<iostream>
#include<math.h>
using namespace std;

// Hàm ki?m tra SCP cách 1
bool isSquareNumber(int a){
    if(a<1)
        return false;
    int i=1;
    while(i*i<=a){
        if(i*i==a)
            return true;
        i++;
        }
    return false;
}

// Hàm ki?m tra SCP cách 2
bool checkSquareNumber(int n){
    if(n<1)
        return false;
    int i = sqrt(n);
    if(i*i==n)
        return true;
    return false;
}

// Ham in ra cac so chinh phuong trong mang
void printSquareNumber(int a[], int n){
    cout<<"Cac so chinh phuong trong mang: \n";
    for(int i=0;i<n;i++)
        if(checkSquareNumber(a[i]))
            cout<<" "<<a[i];
}

int main(){
    int n;
    // Nhap so luong phan tu mang
    do{
        cout<<"Nhap n: ";
        cin>>n;
    }
    while(n<=0);
    
    int a[n]; // Khai bao mang a co n phan tu
    
    cout<<"Nhap mang: "<<endl;
    for(int i=0;i<n;i++){
        cin>>a[i];
    }
    
    printSquareNumber(a,n);
    return 0;
}
