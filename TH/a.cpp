// tính t?ng các ngh?ch d?o t?ng các s? nguyên liên ti?p

int n, i, t;
double s;

Console.write("nhap so nguyen duong n: ");
n = int.Parse(Console.Readline());

s = 0;
t=0;
for(i=1; i<=n;i++)
{
	t += i;
	s += 1 / (double)t;
}
// in kq
Console.WriteLine("S = {0}",s);
