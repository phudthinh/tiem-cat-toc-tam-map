CREATE DATABASE QuanLyTiemCatTocTamMap
GO

USE QuanLyTiemCatTocTamMap
GO

CREATE TABLE NguoiDung
(
	TK NVARCHAR(50),
	MK NVARCHAR(50),
	Ten NVARCHAR(50),
	KieuTocYeuThich NVARCHAR(50),
	GhiChu NVARCHAR(500),
	TongSoTienCatToc INT,
	CheDoToi BIT,
	Loai BIT,
	CONSTRAINT PK_NguoiDung_TK PRIMARY KEY (TK)
)
GO

CREATE TABLE UuDai
(
	MaUuDai INT IDENTITY(1,1),
	TenUuDai NVARCHAR(50),
	PhanTramGiam INT,
	CONSTRAINT PK_UuDai_MaUuDai PRIMARY KEY (MaUuDai)
)
GO

CREATE TABLE KieuToc
(
	MaKieuToc INT IDENTITY(1,1),
	TenKieuToc NVARCHAR(50),
	GiaTien INT,
	CONSTRAINT PK_KieuToc_MaKieuToc PRIMARY KEY (MaKieuToc)
)
GO

CREATE TABLE DichVu
(
	MaDichVu INT IDENTITY(1,1),
	TenDichVu NVARCHAR(50),
	GiaTien INT,
	CONSTRAINT PK_DichVu_MaDichVu PRIMARY KEY (MaDichVu)
)
GO

CREATE TABLE LichSuGiaoDich
(
	MaLSGD INT IDENTITY(1,1),
	Ten NVARCHAR(50),
	NgayThanhToan DATETIME,
	TongSoTienThanhToan INT,
	CONSTRAINT PK_LichSuGiaoDich_MaLSGD PRIMARY KEY (MaLSGD)
)
GO

INSERT INTO NguoiDung
(TK, MK, Ten, KieuTocYeuThich, GhiChu, TongSoTienCatToc, CheDoToi, Loai)
VALUES
(N'ad', N'1', N'Tâm mập', N'', N'', 0, 0, 0),
(N'ad2', N'1', N'Phương Uyên', N'Môi cần chéo', N'Lần sau cứ cắt môi cần chéo', 0, 0, 0)
GO

-- Truy vấn
-- Đăng nhập
CREATE PROC DangNhap
@TK NVARCHAR(50),
@MK NVARCHAR(50)
AS
BEGIN
SELECT
	*
FROM
	NguoiDung
WHERE
	NguoiDung.TK = @TK AND
	NguoiDung.MK = @MK AND
	NguoiDung.Loai = 0
END

-- EXEC DangNhap N'ad' , N'1'
GO

-- View Danh sách người dùng
CREATE VIEW VIEWDanhSachNguoiDung
AS
SELECT
	TK AS N'Tài khoản',
	TEN AS N'Tên người dùng',
	KieuTocYeuThich AS N'Kiểu tóc yêu thích',
	GhiChu AS N'Ghi chú'
FROM
	NguoiDung
WHERE
	Loai = 1
GO
SELECT * FROM ViewDanhSachNguoiDung
GO
-- Tạo tài khoản người dùng
CREATE PROC TaoTaiKhoanNguoiDung
@TK NVARCHAR(50),
@Ten NVARCHAR(50),
@KieuTocYeuThich NVARCHAR(50),
@GhiChu NVARCHAR(50)
AS
BEGIN
INSERT INTO NguoiDung
(TK, MK, Ten, KieuTocYeuThich, GhiChu, TongSoTienCatToc, CheDoToi, Loai)
VALUES
(@TK, N'1', @Ten, @KieuTocYeuThich, @GhiChu, 0, 0, 1)
END
-- EXEC TaoTaiKhoanNguoiDung N'nd1' , N'Tâm gầy' , N'' , N''
-- EXEC TaoTaiKhoanNguoiDung N'nd2' , N'Tâm béo' , N'' , N''
-- EXEC TaoTaiKhoanNguoiDung N'nd3' , N'Tâm Loli' , N'' , N''
GO

-- Chỉnh sửa tài khoản người dùng
CREATE PROC ChinhSuaTaiKhoanNguoiDung
@TK NVARCHAR(50),
@Ten NVARCHAR(50),
@KieuTocYeuThich NVARCHAR(50),
@GhiChu NVARCHAR(50)
AS
BEGIN
UPDATE NguoiDung SET Ten = @Ten , KieuTocYeuThich = @KieuTocYeuThich, GhiChu = @GhiChu WHERE TK = @TK
END
-- EXEC ChinhSuaTaiKhoanNguoiDung N'ad' , N'Tâm mập' , N'' , N''
GO

-- Xóa tài khoản người dùng
CREATE PROC XoaTaiKhoanNguoiDung
@TK NVARCHAR(50)
AS
BEGIN
DELETE FROM NguoiDung WHERE TK = @TK
END
-- EXEC XoaTaiKhoanNguoiDung N'nd1' , N'Tâm gầy' , N'' , N''
GO

-- Kiểm tra tài khoản trùng
CREATE PROC KiemTraTaiKhoanTrung
@TK NVARCHAR(50)
AS
BEGIN
SELECT
	*
FROM
	NguoiDung
WHERE
	NguoiDung.TK = @TK
END
GO

EXEC KiemTraTaiKhoanTrung N'ad'
GO

-- View Danh sách ưu đãi
CREATE VIEW VIEWDanhSachUuDai
AS
SELECT
	MaUuDai AS N'Mã ưu đãi',
	TenUuDai AS N'Tên ưu đãi',
	PhanTramGiam AS N'Phần trăm giảm giá'
FROM
	UuDai
GO
SELECT * FROM VIEWDanhSachUuDai
GO

-- Tạo ưu đãi
CREATE PROC TaoUuDai
@TenUuDai NVARCHAR(50),
@PhanTramGiam INT
AS
BEGIN
INSERT INTO UuDai
(TenUuDai, PhanTramGiam)
VALUES
(@TenUuDai, @PhanTramGiam)
END
-- EXEC TaoUuDai N'Đầu Goku' , 5
GO

-- Chỉnh sửa ưu đãi
CREATE PROC ChinhSuaUuDai
@MaUuDai INT,
@TenUuDai NVARCHAR(50),
@PhanTramGiam INT
AS
BEGIN
UPDATE UuDai SET TenUuDai = @TenUuDai , PhanTramGiam = @PhanTramGiam WHERE MaUuDai = @MaUuDai
END
-- EXEC ChinhSuaTaiKhoanNguoiDung N'2' , 8, 1
GO

-- Xóa ưu đãi
CREATE PROC XoaUuDai
@MaUuDai INT
AS
BEGIN
DELETE FROM UuDai WHERE MaUuDai = @MaUuDai
END
-- EXEC XoaUuDai N'1'
GO

-- View Danh sách kiểu tóc
CREATE VIEW VIEWDanhSachKieuToc
AS
SELECT
	MaKieuToc AS N'Mã kiểu tóc',
	TenKieuToc AS N'Tên kiểu tóc',
	GiaTien AS N'Giá tiền'
FROM
	KieuToc
GO
SELECT * FROM VIEWDanhSachKieuToc
GO

-- Tạo kiểu tóc
CREATE PROC TaoKieuToc
@TenKieuToc NVARCHAR(50),
@GiaTien INT
AS
BEGIN
INSERT INTO KieuToc
(TenKieuToc, GiaTien)
VALUES
(@TenKieuToc, @GiaTien)
END
-- EXEC TaoKieuToc N'Đầu Goku' , 100000
GO

-- Chỉnh sửa kiểu tóc
CREATE PROC ChinhSuaKieuToc
@MaKieuToc INT,
@TenKieuToc NVARCHAR(50),
@GiaTien INT
AS
BEGIN
UPDATE KieuToc SET TenKieuToc = @TenKieuToc, GiaTien = @GiaTien WHERE MaKieuToc = @MaKieuToc
END
-- EXEC ChinhSuaKieuToc N'Đầu Goku' , 90000, 1
GO

-- Xóa kiểu tóc
CREATE PROC XoaKieuToc
@MaKieuToc INT
AS
BEGIN
DELETE FROM KieuToc WHERE MaKieuToc = @MaKieuToc
END
-- EXEC XoaKieuToc N'1'
GO

-- View Danh sách dịch vụ
CREATE VIEW VIEWDanhSachDichVu
AS
SELECT
	MaDichVu AS N'Mã dịch vụ',
	TenDichVu AS N'Tên dịch vụ',
	GiaTien AS N'Giá tiền'
FROM
	DichVu
GO
SELECT * FROM VIEWDanhSachDichVu
GO

-- Tạo dịch vụ
CREATE PROC TaoDichVu
@TenDichVu NVARCHAR(50),
@GiaTien INT
AS
BEGIN
INSERT INTO DichVu
(TenDichVu, GiaTien)
VALUES
(@TenDichVu, @GiaTien)
END
-- EXEC TaoDichVu N'Gội đầu' , 100000
GO

-- Chỉnh sửa dịch vụ
CREATE PROC ChinhSuaDichVu
@MaDichVu INT,
@TenDichVu NVARCHAR(50),
@GiaTien INT
AS
BEGIN
UPDATE DichVu SET TenDichVu = @TenDichVu, GiaTien = @GiaTien WHERE MaDichVu = @MaDichVu
END
-- EXEC ChinhSuaKieuToc 1, N'Đầu Goku' , 90000
GO

-- Xóa dịch vụ
CREATE PROC XoaDichVu
@MaDichVu INT
AS
BEGIN
DELETE FROM DichVu WHERE MaDichVu = @MaDichVu
END
-- EXEC XoaDichVu N'1'
GO

-- View Danh sách Kiểu tóc tính tiền
CREATE VIEW VIEWDanhSachKieuTocTinhTien
AS
SELECT
	TenKieuToc
FROM
	KieuToc
GO
SELECT * FROM VIEWDanhSachKieuTocTinhTien

-- View Danh sách dịch vụ tính tiền
CREATE VIEW VIEWDanhSachDichVuTinhTien
AS
SELECT
	TenDichVu
FROM
	DichVu
GO
SELECT * FROM VIEWDanhSachDichVuTinhTien

-- View Danh sách dịch vụ giá tièn
CREATE PROC GiaTienDichVu
@TenDichVu NVARCHAR(50)
AS
BEGIN
SELECT
	GiaTien
FROM
	DichVu
WHERE
	DichVu.TenDichVu = @TenDichVu
END

-- EXEC GiaTienDichVu N'Gội đầu'

-- View Danh sách ưu đãi tính tiền
CREATE VIEW VIEWDanhSachUuDaiTinhTien
AS
SELECT
	TenUuDai
FROM
	UuDai
GO
SELECT * FROM VIEWDanhSachUuDaiTinhTien

-- View Danh sách dịch vụ giá tièn
CREATE PROC PhanTramGiamUuDai
@TenUuDai NVARCHAR(50)
AS
BEGIN
SELECT
	PhanTramGiam
FROM
	UuDai
WHERE
	UuDai.TenUuDai = @TenUuDai
END

-- EXEC PhanTramGiamUuDai N'ud3'

GO

CREATE PROC AllTongGiaTienDichVu
AS
BEGIN
SELECT
	SUM(GiaTien)
FROM
	DichVu
END

-- EXEC AllTongGiaTienDichVu

GO

-- View Danh sách kiểu tóc giá tièn
CREATE PROC GiaTienKieuToc
@TenKieuToc NVARCHAR(50)
AS
BEGIN
SELECT
	GiaTien
FROM
	KieuToc
WHERE
	KieuToc.TenKieuToc = @TenKieuToc
END

-- EXEC GiaTienKieuToc N'Đầu cắt moi'

-- Tạo lịch sử giao dịch
CREATE PROC TaoLichSuGiaoDich
@Ten NVARCHAR(50),
@TongSoTienThanhToan INT
AS
BEGIN
INSERT INTO LichSuGiaoDich
(Ten, NgayThanhToan, TongSoTienThanhToan)
VALUES
(@Ten, GETDATE(), @TongSoTienThanhToan)
END
-- EXEC TaoLichSuGiaoDich N'Tâm râu' , 100000
GO

-- View Danh sách lịch sử giao dịch
CREATE VIEW VIEWDanhSachLichSuGiaoDich
AS
SELECT
	MaLSGD AS N'Mã LSGD',
	Ten AS N'Tên khách hàng',
	NgayThanhToan AS N'Ngày thanh toán',
	TongSoTienThanhToan AS N'Tổng tiền'
FROM	
	LichSuGiaoDich
GO
SELECT * FROM VIEWDanhSachLichSuGiaoDich

-- Get tổng doanh thu
CREATE VIEW GetTongDoanhThu
AS
SELECT
	SUM(TongSoTienThanhToan) AS N'Tổng tiền'
FROM	
	LichSuGiaoDich
GO
SELECT * FROM GetTongDoanhThu

-- Get Tên người dùng Thông
CREATE PROC GetTenNguoiDung
@TK NVARCHAR(50)
AS
BEGIN
SELECT
	TEN
FROM
	NguoiDung
WHERE
	TK = @TK
END
-- EXEC GetTenNguoiDung N'ad'
GO

-- Kiểm tra mật khẩu
CREATE PROC KiemTraMatKhauTrung
@TK NVARCHAR(50),
@MK NVARCHAR(50)
AS
BEGIN
SELECT
	*
FROM
	NguoiDung
WHERE
	NguoiDung.TK = @TK AND NguoiDung.MK = @MK
END
GO

EXEC KiemTraMatKhauTrung N'ad', N'1'
GO

-- Chỉnh sửa mật khẩu tài khoản người dùng
CREATE PROC ChinhSuaMatKhauTaiKhoanNguoiDung
@TK NVARCHAR(50),
@MK NVARCHAR(50)
AS
BEGIN
UPDATE NguoiDung SET MK = @MK WHERE TK = @TK
END
-- EXEC ChinhSuaMatKhauTaiKhoanNguoiDung N'ad' , N'2'
GO