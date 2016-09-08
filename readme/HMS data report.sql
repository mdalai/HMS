
--- 1. �շ����� ----------------
SELECT ID  '�Һ�ID', 
       patient_name '����', 
	   patient_age '����', 
	   sex '�Ա�', 
	   patient_contact '��ϵ��ʽ', 
	   doctor 'ҽʦ', 
	   pay_date '��������', 
	   pay_amount '���'
 FROM patient_work WHERE work_type in(3,4);

--- 2. ����ͳ���շѽ�� ----------------
 SELECT CAST(pay_date AS DATE) '����', SUM(pay_amount) 'ÿ���ܶ�'
 FROM patient_work WHERE work_type in(3,4) Group by CAST(pay_date AS DATE);

---3. �������� ----------------
 SELECT PID '�Һ�ID', p_medicine_name 'ҩ��', p_unit_price '����', 
        p_sale_unit '��λ', p_amount '����', 
		p_row_total '���', insert_date '����������'
 FROM prescription WHERE exists(SELECT 1 FROM patient_work WHERE work_type in(3,4) and ID=PID )

---4. ��ҩƷͳ�� ----------------
 SELECT p_medicine_name 'ҩ��', SUM(p_amount) '������', SUM(p_row_total) '�����ܶ�'
 FROM prescription WHERE exists(SELECT 1 FROM patient_work WHERE work_type in(3,4) and ID=PID ) 
 GROUP BY p_medicine_name

---5. �����շ��� ----------------
  SELECT PFID '�Һ�ID', pf_feeitem_name '�շ�������', pf_feeitem_price '�۸�', insert_date '��������'
 FROM prescription_feeitem WHERE exists(SELECT 1 FROM patient_work WHERE work_type in(3,4) and ID=PFID )

---6. ���շ���ͳ�� ----------------
  SELECT pf_feeitem_name '�շ�������', SUM(pf_feeitem_price) '�ܶ�'
 FROM prescription_feeitem WHERE exists(SELECT 1 FROM patient_work WHERE work_type in(3,4) and ID=PFID )
 GROUP BY pf_feeitem_name

---7. ���շ���ͳ�� ----------------
 SELECT GID '�Һ�ID',
        current_price_total '�˷�ǰ���', 
		refund_total '�˷ѽ��',
		new_price_total '�˷Ѻ���' 
	FROM refund





