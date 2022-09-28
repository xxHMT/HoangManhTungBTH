namespace HoangManhTungBTH.Models.Process;
{
    public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
    {
        string message = "";
        double x;
        if (heSoA == 0)
        {
            if (heSoB == 0)
            {
                message = "Phuong trinh co vo so nghiem";
            }
            else
            {
                message = "Phuong trinh vo nghiem";
            }
        }
        else
        {
            x = -heSoB / heSoA;
            message = "Phuong trinh co nghiem x = " + x;
        }
        return message;
    }

    public string GiaiPhuongTrinhBacHai(double a, double b, double )
    {
        double x, y, delta;
        string message = "";

// Giai phuong trinh bac nhat
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    message = "Phuong trinh co vo so nghiem";
                }
                else
                {
                    message = "Phuong trinh vo nghiem";
                }
            }else {
                x = (double)-c / b;
                message = "Phuong trinh co 1 nghiem duy nhat x = " + x;
            }
            return message;
        }
// a != 0 => giai phuong trinh bac hai
        else
        {
            delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta < 0) 
            {
                message = "Phuong trinh vo nghiem";
            }
            else if(delta == 0)
            {
                x = y = -b /(2 * a);
                message = "Phuong trinh co nghiem kep x1, x2 = " + x;
            }
            else {
                x = (-b + Math.Sqrt(delta)) / (2 * a);
                y = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Phuong trinh co 2 nghiem: x1 = " + x + "va x2 = " + y; 
            }
        }
        return message;
    }
}