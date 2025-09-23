public class Method
// public : công cộng - những nơi khác có thể truy cập được
{

    

    // static - tĩnh : 
    public static void BT1()
    {
        // code các function chức năng tương ứng

        int n = 0;
        Console.Write("Nhập số nguyên n: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Vui lòng nhập một số nguyên hợp lệ: ");
        }
        Console.WriteLine("Bảng cửu chương 5");
        // in ra bảng cửu chương của n từ 1 đến 10
        for (int i = 1; i <= 10; i++)
        {

            Console.WriteLine($"{n} x {i} = {n * i}");

        }
    }

    // BÀI TÍNH ĐIỂM TRUNG BÌNH
    // nhâp điểm 3 môn


    // tính điểm trung bình
    // show xếp loại - dtb 
    // return trả về giá trị 
    public static void TinhDiemTrungBinh()
    {
        // nhập toán
        double toan = Method.NhapDiem("Toán");
        // nhập lý
        double ly = NhapDiem("Lý");
        // nhập hóa
        double hoa = NhapDiem("Hóa");

        // tính điểm trung bình - tách ra function tính điểm tb 
        // gọi hàm tính diem trung bình nhận vào 3 tham số => return về điểm trung bình

        double dtb = TinhDTB(toan, ly, hoa);// hàm trả về điểm trung bình nên cần phải gán vào biến
        // xếp loại
        // hàm nhận vào dtb => string
        string kq = XepLoai(dtb);
        Console.WriteLine(kq);
    }









    // nhập điểm và return điểm của môn mình nhâp - hàm có return
    // viết 1 function có thể tái sử dụng cho 3 lần nhập điểm
    public static double NhapDiem(string monHoc)
    {
        Console.Write($"Nhập điểm {monHoc}: ");
        double diem = int.Parse(Console.ReadLine());
        return diem;
    }
    public static double TinhDTB(double toan, double ly, double hoa)
    {
        // tính điểm trung bình
        return (toan + ly + hoa) / 3;
    }
    // xếp loại Nhận vào dtb và trả về xếp loại : string
    public static string XepLoai(double dtb)
    {
        string xepLoai = "";
        switch (dtb)
        {
            case > 8.5:
                xepLoai = $"Xếp loại Giỏi - {dtb}";
                break;
            case > 7.0:
                xepLoai = $"Xếp loại Khá - {dtb}";
                break;
            case > 5.0:
                xepLoai = $"Xếp loại Trung bình - {dtb}";
                break;
            case > 3.0:
                xepLoai = $"Xếp loại Yếu - {dtb}";
                break;

        }
        return xepLoai;
    }




}








// TÊN BIẾN hoThi
// tên function TinhDiemTrungBinh
// 
//