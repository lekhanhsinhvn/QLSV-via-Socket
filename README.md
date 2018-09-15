# QLSV via Socket

Sinhvien:
	int id
	string ten
	string password
	int sdt
	bool gioi_tinh
	string diachi
	datetime ngay_sinh
	list<Khoahoc> dang_hoc
	list<Khoahoc> dang_ki
	list<Khoahoc> da_hoc

Khoahoc:
	int id
	string ten;
	list<Sinhvien> danh_sach
	float chuyen_can
	float giua_ki
	float cuoi_ki
	bool dang_ky
	int max_danhsach 
	datetime batdau_dangky
	datetime han_dangky

Form: 
	Server:
	1 datagridview xem duoc list<Khoahoc>, list<Sinhvien>
	mac dinh list<Khoahoc>
	click vao selected Khoahoc chuyen doi datagridview hien thi list<Sinhvien> trong Khoahoc
	ratio cho Khoahoc sap co, dang co, het han
	textbox nhap tim kiem
	button them, xoa, chinh sua, tim kiem
	
	Client:
	1 datagridview xem duoc list<Khoahoc>, list<Sinhvien>
	mac dinh list<Khoahoc>
	click vao selected Khoahoc chuyen doi datagridview hien thi list<Sinhvien>
	ratio cho Khoahoc sap co, dang co, het han
	textbox nhap tim kiem
	button dang ky , huy, tim kiem