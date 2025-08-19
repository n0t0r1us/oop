#include <stdio.h>
#include <math.h>
//H�m kiem tra so nguy�n to
bool checkNT(int n)
{
    if(n<2) return false;
    int sq = sqrt(n);
    for(int i=2;i <=sq ;i++){
        if(n % i == 0){
            return false;
        }
    }
    return true;
}
   
int main()
{
    int n;
    printf("Nhap n:");
    scanf("%d", &n); //Nhap n tu b�n ph�m
      
    int dem = 0; //Khoi tao bien dem = 0
    for(int i=1;i<=n;i++){
        if(checkNT(i) == true)
         printf("%d ", i);//N�u i l� so nguy�n to th� ta in bien i ra m�n h�nh
    }
}
