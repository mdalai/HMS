/************ Database: HMS ********************/
/***Download SQL Server 2014 Express *******/
https://www.microsoft.com/en-us/server-cloud/products/sql-server-editions/sql-server-express.aspx
/***Create DB: HMS *******/



/************ Table 1: staff ********************/
CREATE SEQUENCE se_staff
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
CREATE TABLE staff
     ( 
        staff_id          INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_staff   NOT NULL, 
        staff_name        VARCHAR(50) NOT NULL,
	staff_password    VARCHAR(50) NOT NULL,
        job_type          VARCHAR(20) NOT NULL,         
        department        VARCHAR(50)  NULL, 
        work_date         SMALLDATETIME NULL,
	remark            VARCHAR(100)  NULL,
	created_Date	DATETIME NULL,
	staff_status  	VARCHAR(20) NULL, /*��Ч����ɾ��*/
	delete_date 	DATETIME NULL,
     )
GO

INSERT INTO dbo.staff (staff_name, staff_password, job_type, department, work_date, remark) 
   VALUES ('����Ա','4321','ϵͳ����Ա','ϵͳ����', '2016-2-14','ϵͳ����Ա');
GO
SELECT * FROM dbo.staff;

/************ Table 2: status_type ********************/
CREATE TABLE status_type
     ( 
        ID INT NOT NULL, 
        status_type VARCHAR(100) NOT NULL, /* 1:�ѹҺ� 2:�ѿ�����  3:�Ѹ���  4:�ѷ�ҩ  5:�Һź�ȡ�� 6:��������ȡ�� 7:ȡҩǰ�˷� 8:ȡҩ���˷� */*/      
     )
INSERT INTO status_type (ID,status_type) VALUES (1,'�ѹҺ�'),(2,'�ѿ�����'),(3,'�Ѹ���'),(4,'�ѷ�ҩ'),
    (5,'�Һź�ȡ��'),(6,'��������ȡ��')
INSERT INTO status_type (ID,status_type) VALUES (7,'ȡҩǰ�˷�'), (8,'ȡҩ���˷�')
SELECT * FROM status_type;


/************ Table 3: patient_work ********************/
CREATE SEQUENCE se_patient_work
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE

CREATE TABLE patient_work
     ( 
        ID INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_patient_work NOT NULL, 
        patient_name VARCHAR(100) NOT NULL,
	patient_id VARCHAR(30) NOT NULL,
	patient_age VARCHAR(10) NOT NULL,
	sex VARCHAR(6) NULL,
	patient_contact VARCHAR(30) NULL,
	doctor VARCHAR(50) NOT NULL,
        work_type VARCHAR(4) NOT NULL,   /* 1:�ѹҺ� 2:�ѿ�����  3:�Ѹ���  4:��ȡҩ  5:�Һź�ȡ�� */      
        guahao_date  DATETIME  NULL, 
        chufang_date  DATETIME NULL,
	pay_date  DATETIME NULL,
        pay_amount DECIMAL(8,2) NULL, 
	quyao_date  DATETIME NULL,        
        medicine_giver VARCHAR(50) NULL,
        status_update_date DATETIME NULL,

     )
GO

/************ Table 4: medicine ********************/
CREATE SEQUENCE se_medicine
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
CREATE TABLE medicine
     ( 
        medicine_ID INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_medicine   NOT NULL,  /*ҩƷ����*/
        medicine_name VARCHAR(100) NOT NULL,  /*ҩ��*/
	medicine_norms VARCHAR(50) NULL,  /*���*/
	unit VARCHAR(10) NULL, /*��λ*/
	unit_price DECIMAL(8,2) NULL, /*����*/
	sale_unit VARCHAR(10) NULL, /*���۵�λ*/
	sale_unit_price DECIMAL(8,2) NULL, /*���۵���*/
	storage INT NULL, /*�����*/
	alias VARCHAR(100) NULL,  /*����*/
	production VARCHAR(100) NULL, /*��������*/
	instruction VARCHAR(150) NULL, /*�÷�*/
	medicine_status VARCHAR(20) NULL, /*1-��Ч, 2-��Ч*/
	created_date DATETIME NULL, /*�������*/
	cancelled_date DATETIME NULL, /*ɾ������*/
		
     )
GO

INSERT INTO medicine (medicine_name,medicine_norms,unit,unit_price,sale_unit,sale_unit_price,alias,production,medicine_status) 
   VALUES ('������ƽƬ','5mg*100Ƭ', 'ƿ','3.5','Ƭ','0.035','��ʹ��','','1')


/************ Table 5: prescription ********************/

CREATE TABLE prescription
     ( 
        PID  INT NOT NULL, 
        p_medicine_name VARCHAR(100) NOT NULL,
		p_sale_unit VARCHAR(10) NULL,
		p_unit_price DECIMAL(8,2) NOT NULL,
		p_amount INT NOT NULL,
		p_row_total DECIMAL(8,2) NOT NULL,
		p_norms VARCHAR(50) NULL,
		p_instruction VARCHAR(150) NULL,
		insert_date Datetime NULL,
						
		CONSTRAINT FK_prescription_patient FOREIGN KEY (PID) 
             REFERENCES patient_work (ID)			 
             ON DELETE CASCADE
             ON UPDATE CASCADE
     )
GO

/************ Table 7: medicine_storage ********************/
CREATE TABLE medicine_storage
     ( 
        medicine_ID INT NOT NULL,  /*ҩƷ����*/
        medicine_name VARCHAR(100) NOT NULL,  /*ҩ��*/
	medicine_norms VARCHAR(50) NULL,  /*���*/
	sale_unit VARCHAR(10) NULL, /*���۵�λ*/
	sale_unit_price DECIMAL(8,2) NULL, /*���۵���*/
	current_storage INT NULL, /*���п����*/
	add_storage INT NULL,  /*���������*/
	storage INT NULL, /*�����*/
	insert_date DATETIME NULL, /*�������*/

	CONSTRAINT FK_medicine_storage FOREIGN KEY (medicine_ID) 
             REFERENCES medicine (medicine_ID)			 
             ON DELETE CASCADE
             ON UPDATE CASCADE		
     )

/************ Table 8: prescription_remark ********************/
CREATE TABLE prescription_remark
     ( 
        GID INT PRIMARY KEY NOT NULL,  /*�Һ�ID*/
        prescription_remark VARCHAR(MAX) NULL,  /*��������*/
	    insert_date DATETIME NULL, /*�������*/

	CONSTRAINT FK_prescription_remark FOREIGN KEY (GID) 
             REFERENCES patient_work (ID)			 
             ON DELETE CASCADE
             ON UPDATE CASCADE		
     )

/************ Table 9: Feeitem ********************/
CREATE SEQUENCE se_Feeitem
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
CREATE TABLE Feeitem
     ( 
        FID INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_Feeitem NOT NULL,  /*ID*/
        feeitem_name VARCHAR(100) NOT NULL,  /*�շ���*/
		feeitem_price DECIMAL(8,2) NULL, /*�۸�*/
		feeitem_remark VARCHAR(100) NULL, /*˵��*/
		feeitem_status VARCHAR(20) NULL, /*1-�̶�����,2-�䶯����,3-��Ч*/
	    create_date DATETIME NULL, /*��������*/
     )


/************ Table 10: prescription_feeitem ********************/

CREATE TABLE prescription_feeitem
     ( 
        PFID  INT  NOT NULL, 
        pf_feeitem_name VARCHAR(100) NOT NULL,
		pf_feeitem_price DECIMAL(8,2) NOT NULL,
		insert_date Datetime NULL,
				
		CONSTRAINT FK_prescription_feeitem FOREIGN KEY (PFID) 
             REFERENCES patient_work (ID)			 
             ON DELETE CASCADE
             ON UPDATE CASCADE
     )
GO

/************ Table 11: refund ********************/

CREATE TABLE refund
     ( 
        GID  INT NOT NULL, 
        current_medi_total DECIMAL(8,2) NULL,
		current_feeitem_total DECIMAL(8,2) NULL,
		current_price_total DECIMAL(8,2) NULL,
		refund_total DECIMAL(8,2) NULL,
		new_price_total DECIMAL(8,2) NULL,
		work_type VARCHAR(4) NULL,   /* 7:ȡҩǰ�˷� 8:ȡҩ���˷� */
		insert_date Datetime NULL,
						
		CONSTRAINT FK_refund FOREIGN KEY (GID) 
             REFERENCES patient_work (ID)			 
             ON DELETE CASCADE
             ON UPDATE CASCADE
     )

/************ Table 12: medi_usage1 ********************/
CREATE SEQUENCE se_medi_usage1
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
CREATE TABLE medi_usage1
     ( 
        ID INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_medi_usage1 NOT NULL,  /*ID*/
        medi_usage1_name VARCHAR(100) NOT NULL,  /*�÷�*/
     )

insert into medi_usage1(medi_usage1_name) values ('�ڷ�');

/************ Table 13: medi_usage2 ********************/
CREATE SEQUENCE se_medi_usage2
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
CREATE TABLE medi_usage2
     ( 
        ID INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_medi_usage2 NOT NULL,  /*ID*/
        medi_usage2_name VARCHAR(100) NOT NULL,  /*����*/
     )

/************ Table 14: medi_use_unit ********************/
CREATE SEQUENCE se_medi_use_unit
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
CREATE TABLE medi_use_unit
     ( 
        ID INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_medi_use_unit NOT NULL,  /*ID*/
        medi_use_unit VARCHAR(100) NOT NULL,  /*����*/
     )


select * from medi_usage2


select * from prescription where PID = 4
select * from patient_work where ID = 4
select * from prescription_feeitem WHERE  PFID = 4
select * from refund WHERE  GID = 4
select * from medicine;
select * from medicine_storage;
select * from prescription_remark;
select * from staff;
select * from Feeitem

update feeitem set feeitem_status=2 where fid=1


select * from patient_work where work_type in ('3','4','7','8') order by quyao_date desc

ALTER TABLE prescription ADD p_sale_unit VARCHAR(10) NULL;
ALTER TABLE medicine ADD storage INT NULL;
update medicine set storage = 30

ALTER TABLE medicine ADD instruction VARCHAR(150) NULL;
ALTER TABLE prescription ADD p_instruction VARCHAR(150) NULL;
ALTER TABLE prescription ADD p_norms VARCHAR(50) NULL;

ALTER TABLE patient_work ADD sex VARCHAR(6) NULL;

ALTER TABLE staff ADD created_Date DATETIME NULL, staff_status VARCHAR(20) NULL, delete_date DATETIME NULL;
Update staff set staff_status = '��Ч'



select * from prescription A, medicine B where A.p_medicine_name=B.medicine_name AND  PID=5

select * 
from medicine me, prescription pr WHERE me.medicine_name=pr.p_medicine_name AND pr.PID = 2024

UPDATE me
SET  me.storage = me.storage - pr.p_amount
from medicine me, prescription pr WHERE me.medicine_name=pr.p_medicine_name AND pr.PID = 2024

select *,CASE work_type WHEN '2' THEN '�ѿ�����' WHEN '3' THEN '�Ѹ���' WHEN '4' THEN '�ѷ�ҩ' END 
from patient_work;
SELECT * FROM status_type;

UPDATE patient_work SET work_type= CASE work_type WHEN '1' THEN '5' WHEN '2' THEN '6' END
WHERE ID = 2

select * from patient_work where id=15;

---- working with Sequence -------------------------
CREATE SEQUENCE se_patient_work
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE;

SELECT NEXT VALUE FOR se_patient_work;

SELECT cache_size, current_value 
FROM sys.sequences
WHERE name = se_patient_work;

ALTER SEQUENCE se_patient_work RESTART WITH 1;
SELECT NEXT VALUE FOR se_patient_work;

DROP SEQUENCE se_patient_work;



----- Adding primary Key -----------------------------

CREATE SEQUENCE se_refund
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
Alter table refund add refund_id INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_refund   NOT NULL;

CREATE SEQUENCE se_prescription
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
ALTER TABLE prescription ADD prescription_id INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_prescription  NOT NULL;

CREATE SEQUENCE se_pf
    AS INT
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE
ALTER TABLE prescription_feeitem ADD pf_id INT PRIMARY KEY DEFAULT NEXT VALUE FOR se_pf  NOT NULL;

