
--- 1. 收费数据 ----------------
SELECT ID  '挂号ID', 
       patient_name '姓名', 
	   patient_age '年龄', 
	   sex '性别', 
	   patient_contact '联系方式', 
	   doctor '医师', 
	   pay_date '交费日期', 
	   pay_amount '金额'
 FROM patient_work WHERE work_type in(3,4);

--- 2. 按日统计收费金额 ----------------
 SELECT CAST(pay_date AS DATE) '日期', SUM(pay_amount) '每日总额'
 FROM patient_work WHERE work_type in(3,4) Group by CAST(pay_date AS DATE);

---3. 处方数据 ----------------
 SELECT PID '挂号ID', p_medicine_name '药名', p_unit_price '单价', 
        p_sale_unit '单位', p_amount '数量', 
		p_row_total '金额', insert_date '开处方日期'
 FROM prescription WHERE exists(SELECT 1 FROM patient_work WHERE work_type in(3,4) and ID=PID )

---4. 按药品统计 ----------------
 SELECT p_medicine_name '药名', SUM(p_amount) '销售量', SUM(p_row_total) '销售总额'
 FROM prescription WHERE exists(SELECT 1 FROM patient_work WHERE work_type in(3,4) and ID=PID ) 
 GROUP BY p_medicine_name

---5. 其他收费项 ----------------
  SELECT PFID '挂号ID', pf_feeitem_name '收费项名称', pf_feeitem_price '价格', insert_date '生成日期'
 FROM prescription_feeitem WHERE exists(SELECT 1 FROM patient_work WHERE work_type in(3,4) and ID=PFID )

---6. 按收费项统计 ----------------
  SELECT pf_feeitem_name '收费项名称', SUM(pf_feeitem_price) '总额'
 FROM prescription_feeitem WHERE exists(SELECT 1 FROM patient_work WHERE work_type in(3,4) and ID=PFID )
 GROUP BY pf_feeitem_name

---7. 按收费项统计 ----------------
 SELECT GID '挂号ID',
        current_price_total '退费前金额', 
		refund_total '退费金额',
		new_price_total '退费后金额' 
	FROM refund





