#include<iostream>
#include<time.h>
#include<stdlib.h>
#include<graphics.h>
#include<dos.h>
using namespace std;
int Random(int a, int b)
{ 
	srand(time(NULL));
	return a + rand()%(b-a+1);
}
int ktmanhinhx=700-12,ktmanhinhy=500-12;

int r=90;
int bankinh=50;
int SizeW=20;
int Sizet=SizeW-3;
char bkcolor=11;
void VeBongRong(int x,int y)
{
	setcolor(bkcolor);
	setfillstyle(1,bkcolor);
	pieslice(x,y,0,360,bankinh);
}

int a1,b1,a2,b2,a3,b3,a4,b4,a5,b5;
void RandomToaDo()// hàm tao to do random
{
	cout<<"Dang tim toa do vector!! xin vui long cho trong giay lat !!";
	do
	{
		a1=Random(-1,1);
	}
	while(a1==0);
	
	do
	{
		b1=Random(2,4);
	}
	while(b1==0);
	
	do
	{
		a2=Random(2,4);
	}
	while(a2==0);
	
	do{
		b2=Random(-1,1);
	}
	while(b2==0);
	
	do
	{
		a3=Random(-1,1);
	}
	while(a3==0);
	
	do
	{
		b3=Random(-4,-2);
	}
	while(b3==0);
	
	do{
		a4=Random(-1,1);
	}
	while(a4==0||a4==a3);
	
	do
	{
		b4=Random(-4,-2);
	}
	while(b4==0||b4==b3);
	
	do
	{
		a5=Random(-4,-2);
	}
	while(a5==0);
	
	do
	{
		b5=Random(-1,1);
	}
	while(b5==0);
	cout<<"\nDa tim xong toa do !!";
	cout<<"\nv1("<<a1<<" , "<<b1<<")";
	cout<<"\nv2("<<a2<<" , "<<b2<<")";
	cout<<"\nv3("<<a3<<" , "<<b3<<")";
	cout<<"\nv4("<<a4<<" , "<<b4<<")";
	cout<<"\nv5("<<a5<<" , "<<b5<<")";
}
class Buctuong{
	
	public :
		void Vetuong()// hàm tao biên
		{
		setcolor(6);
		setfillstyle(1,6);
		bar(0,0,Sizet,getmaxy());
		bar(getmaxx()-Sizet,0,getmaxx(),getmaxy());
		bar(0,0,getmaxx(),Sizet);
		bar(0,getmaxy()-Sizet,getmaxx(),getmaxy());
	}
};
// class ve bóng
class Bong{
	public:
		char Mau;
		int x;
		int y;
		int Bankinh=bankinh;
		void VeBong(int x, int y)// hàm ve bóng
		{
			this->x=x;
			this->y=y;
			setcolor(Mau);
			setfillstyle(1,Mau);
			pieslice(x,y,0,360,Bankinh);
		};
	
		Bong(char Mau){
			this->Mau=Mau;
		}
};
//hàm chính	
int main()
{	
	RandomToaDo();
	float y=ktmanhinhy,x=ktmanhinhx,t1=0,t2=0;
	int bk;
	do{
	cout<<"\nNhap ban kinh cho qua bong (20 --> 50): "; cin>>bk;
	}
	while(bk<20 ||bk>50);
	bankinh=bk;
	r=bk*2;
//	readimagefile("image.jpg",0,0,400,200);
	initwindow(700,500);
	graphresult(); 
	setbkcolor(bkcolor);
	Buctuong tuong;
	cleardevice();
	tuong.Vetuong();
	Bong bong1(4);
	Bong bong2(5);
	Bong bong3(14);
	Bong bong4(10);
	Bong bong5(7);
	bong1.VeBong(x/2,y/2+r);
	bong2.VeBong(x/2+0.95*r , y/2+0.3*r);
	bong3.VeBong(x/2+0.6*r,y/2-0.8*r);
	bong4.VeBong(x/2-0.6*r,y/2-0.8*r);
	bong5.VeBong(x/2-0.95*r,y/2+0.3*r);	
	delay(1000);
	cleardevice();
	tuong.Vetuong();
	
	int x1=bong1.x; int y1=bong1.y;	
	int x2=bong2.x; int y2=bong2.y;	
	int x3=bong3.x; int y3=bong3.y;	
	int x4=bong4.x; int y4=bong4.y;	
	int x5=bong5.x; int y5=bong5.y;	
	
	int xmax=ktmanhinhx;
	int ymax=getmaxy();
	int Bankinh=bankinh;
	int vx1=a1,vy1=b1, vx2=a2,vy2=b2, vx3=a3,vy3=b3,vx4=a4,vy4=b4,vx5=a5,vy5=b5;	
	while(1)// hàm di chuyen
	{
		x1=x1+vx1;
		y1=y1+vy1;
		
		x2=x2+vx2;
		y2=y2+vy2;
		
		x3=x3+vx3;
		y3=y3+vy3;
		
		x4=x4+vx4;
		y4=y4+vy4;
		
		x5=x5+vx5;
		y5=y5+vy5;
		
		bong1.VeBong(x1,y1);
		bong2.VeBong(x2,y2);
		bong3.VeBong(x3,y3);
		bong4.VeBong(x4,y4);
		bong5.VeBong(x5,y5);
		delay(30);
		VeBongRong(x1,y1);
		VeBongRong(x2,y2);
		VeBongRong(x3,y3);
		VeBongRong(x4,y4);
		VeBongRong(x5,y5);
		
		if(y1>=ktmanhinhy-Bankinh-SizeW||y2>=ktmanhinhy-Bankinh-SizeW||y3>=ktmanhinhy-Bankinh-SizeW||y4>=ktmanhinhy-Bankinh-SizeW||y5>=ktmanhinhy-Bankinh-SizeW)
			{
			if(y1>=ktmanhinhy-Bankinh-SizeW) //hàm va cham bóng 1
			{
			vx1=vx1;
			vy1=-vy1;
			x1=x1+vx1;
			y1=y1+vy1;
			}
			if(y2>=ktmanhinhy-Bankinh-SizeW) //hàm va cham bóng 2
			{
			vx2=vx2;
			vy2=-vy2;
			x2=x2+vx2;
			y2=y2+vy2;
			}
			if(y3>=ktmanhinhy-Bankinh-SizeW) //hàm va cham bóng 3
			{
			vx3=vx3;
			vy3=-vy3;
			x3=x3+vx3;
			y3=y3+vy3;
			}
			if(y4>=ktmanhinhy-Bankinh-SizeW)//hàm va cham bóng 4
			{
			vx4=vx4;
			vy4=-vy4;
			x4=x4+vx4;
			y4=y4+vy4;
			}
			if(y5>=ktmanhinhy-Bankinh-SizeW)//hàm va cham bóng 5
			{
			vx5=vx5;
			vy5=-vy5;
			x5=x5+vx5;
			y5=y5+vy5;
			}			
			bong1.VeBong(x1,y1);
			bong2.VeBong(x2,y2);
			bong3.VeBong(x3,y3);
			bong4.VeBong(x4,y4);
			bong5.VeBong(x5,y5);
			delay(30);
			VeBongRong(x1,y1);
			VeBongRong(x2,y2);
			VeBongRong(x3,y3);
			VeBongRong(x4,y4);
			VeBongRong(x5,y5);	
		}
		if(y1<=Bankinh+SizeW||y2<=Bankinh+SizeW||y3<=Bankinh+SizeW||y4<=Bankinh+SizeW||y5<=Bankinh+SizeW){
			if(y1<=Bankinh+SizeW){
			vx1=vx1;
			vy1=-vy1;
			x1=x1+vx1;
			y1=y1+vy1;
			}
			if(y2<=Bankinh+SizeW){
			vx2=vx2;
			vy2=-vy2;
			x2=x2+vx2;
			y2=y2+vy2;
			}
			if(y3<=Bankinh+SizeW){
			vx3=vx3;
			vy3=-vy3;
			x3=x3+vx3;
			y3=y3+vy3;
			}
			if(y4<=Bankinh+SizeW){
			vx4=vx4;
			vy4=-vy4;
			x4=x4+vx4;
			y4=y4+vy4;
			}
			if(y5<=Bankinh+SizeW){
			vx5=vx5;
			vy5=-vy5;
			x5=x5+vx5;
			y5=y5+vy5;
			}
			bong1.VeBong(x1,y1);
			bong2.VeBong(x2,y2);
			bong3.VeBong(x3,y3);
			bong4.VeBong(x4,y4);
			bong5.VeBong(x5,y5);
			delay(30);
			VeBongRong(x1,y1);
			VeBongRong(x2,y2);
			VeBongRong(x3,y3);
			VeBongRong(x4,y4);
			VeBongRong(x5,y5);
		}
		if(x1<=Bankinh+SizeW||x2<=Bankinh+SizeW||x3<=Bankinh+SizeW||x4<=Bankinh+SizeW||x5<=Bankinh+SizeW){
			if(x1<=Bankinh+SizeW){
			vx1=-vx1;
			vy1=vy1;
			x1=x1+vx1;
			y1=y1+vy1;
			}
			if(x2<=Bankinh+SizeW){
			vx2=-vx2;
			vy2=vy2;
			x2=x2+vx2;
			y2=y2+vy2;
			}
			if(x3<=Bankinh+SizeW){
			vx3=-vx3;
			vy3=vy3;
			x3=x3+vx3;
			y3=y3+vy3;
			}
			if(x4<=Bankinh+SizeW){
			vx4=-vx4;
			vy4=vy4;
			x4=x4+vx4;
			y4=y4+vy4;
			}
			if(x5<=Bankinh+SizeW){
			vx5=-vx5;
			vy5=vy5;
			x5=x5+vx5;
			y5=y5+vy5;
			}
			bong1.VeBong(x1,y1);
			bong2.VeBong(x2,y2);
			bong3.VeBong(x3,y3);
			bong4.VeBong(x4,y4);
			bong5.VeBong(x5,y5);
			delay(30);
			VeBongRong(x1,y1);
			VeBongRong(x2,y2);
			VeBongRong(x3,y3);
			VeBongRong(x4,y4);
			VeBongRong(x5,y5);				
		}
		if(x1>=ktmanhinhx-Bankinh-SizeW||x2>=ktmanhinhx-Bankinh-SizeW||x3>=ktmanhinhx-Bankinh-SizeW||x4>=ktmanhinhx-Bankinh-SizeW||x5>=ktmanhinhx-Bankinh-SizeW){
			if(x1>=ktmanhinhx-Bankinh-SizeW){
			vx1=-vx1;
			vy1=vy1;
			x1=x1+vx1;
			y1=y1+vy1;
			}
			if(x2>=ktmanhinhx-Bankinh-SizeW){
			vx2=-vx2;
			vy2=vy2;
			x2=x2+vx2;
			y2=y2+vy2;
			}
			if(x3>=ktmanhinhx-Bankinh-SizeW){
			vx3=-vx3;
			vy3=vy3;
			x3=x3+vx3;
			y3=y3+vy3;
			}
			if(x4>=ktmanhinhx-Bankinh-SizeW){
			vx4=-vx4;
			vy4=vy4;
			x4=x4+vx4;
			y4=y4+vy4;
			}
			if(x5>=ktmanhinhx-Bankinh-SizeW){
			vx5=-vx5;
			vy5=vy5;
			x5=x5+vx5;
			y5=y5+vy5;
			}
			bong1.VeBong(x1,y1);
			bong2.VeBong(x2,y2);
			bong3.VeBong(x3,y3);
			bong4.VeBong(x4,y4);
			bong5.VeBong(x5,y5);
			delay(30);
			VeBongRong(x1,y1);
			VeBongRong(x2,y2);
			VeBongRong(x3,y3);
			VeBongRong(x4,y4);
			VeBongRong(x5,y5);	
		}
	}
	getch();
	closegraph();  
	return 0;
}
