
create database if not exists clinic1;
use clinic1;

create table if not exists patient
(
  Ic_number int(11) not null,
  f_namme   nvarchar(10) not null,
  l_name    nvarchar(10) not null,
  address   nvarchar(30) not null,
  phone_number nvarchar(30) not null,
  age  int(11),
  register_day   varchar (20),
  weight  int (10),
  gender nvarchar(5),
primary key(Ic_number)
);
/*creat description table*/

create table if not exists description
(
 desc_id int(10) not null auto_increment ,
 fp_number int not null,
 symptoms   nvarchar(50) not null,
analysis_result  nvarchar(30),
As_a_Result_of_x   nvarchar(30),
chronic_diseases nvarchar(20),
disease_name     nvarchar(20) not null,
day_of_entry    date not null,
day_of_exit varchar(20), 
return_time varchar(20) ,
notes nvarchar(50),
primary key(desc_id),
foreign key (fp_number) references patient(Ic_number)
);
    /*creat medecine table*/

create table if not exists medecine
(
med_code int not null,
trade_name nvarchar(10) not null,
sc_name    nvarchar(10) not null,
effic_ma   nvarchar(10) not null,
effic_side  nvarchar(50),
primary key(med_code)
);
insert into medecine values (1,'tradeName1','ScienceName1','Eff.Materail1','Eff.Side1'),(2,'tradeName2','ScienceName2','Eff.Materail2','Eff.Side2'),
(3,'tradeName3','ScienceName3','Eff.Materail3','Eff.Side3'),(4,'tradeName4','ScienceName4','Eff.Materail4','Eff.Side4'),
(5,'tradeName5','ScienceName5','Eff.Materail5','Eff.Side5');



create table if not exists diseases
(d_id int  not null  auto_increment,
d_name nvarchar(10) not null,
d_type nvarchar(10) ,
side_effict  nvarchar(50),
primary key(d_id)


);
insert into diseases values (1,'name1','type1','effect1'),(2,'name2','type2','effect2'),(3,'name3','type3','effect3'),
(4,'name4','type4','effect4'),(5,'name5','type5','effect5'),(6,'name6','type6','effect6');
insert into diseases values (2,'aa','aaa','aaa'),(3,'as','ass','assd');

  create table if not exists treat_diseases
(
fmed_code int not null,
fd_id int not null,
t_id  int not null,
primary key(t_id) ,
foreign key(fd_id) references diseases(d_id),
foreign key(fmed_code) references medecine(med_code)
);
insert into treat_diseases values (1,1,1),(1,2,2),(1,3,3),(2,2,4),(2,3,5),(2,4,6),(3,5,7);


create table doctor
(
 dr_name nvarchar(30) not null,
dr_age nvarchar(10) not null,
address nvarchar(10) not null,
dr_id int not null,
primary key(dr_id)
);
insert into doctor values ('doctor1',30,'address1',1),('doctor2',30,'address2',2),('doctor3',30,'address3',3),
('doctor4',30,'address4',4);

create table if not exists employee
(
 em_code int(10) not null ,
address nvarchar(20) not null,
jop_type nvarchar(10) not null,
em_name nvarchar(10) not null,
age nvarchar(10) not null,
salary decimal(10) not null,
primary key(em_code)
);
insert into employee values(1,'adress1','jop1','name1',30,800),(2,'adress2','jop2','name2',30,800),
(3,'adress3','jop3','name3',30,800),(4,'adress4','jop4','name4',30,800);
create table if not exists room
(
 room_name nvarchar(10),
room_type nvarchar(10),
room_num int(10),
primary key(room_num)

);
create table if not exists p_medicine
(
fic_num int(10)  not null,
med_name nvarchar(10) not null,
med_quantity nvarchar(10) not null,
taking_time nvarchar(10) not null,
time_for_repeat nvarchar(10) not null ,
foreign key(fic_num) references patient(Ic_number)
);
select * from p_medicine ;
insert into p_medicine values (1,'med1','quantity1','taking1','time1'),(2,'med2','quantity2','taking2','time2'),
(3,'med3','quantity3','taking3','time3');

create table users (
id int primary key,
uid varchar(30) not null,
pwd varchar(30) not null

);









