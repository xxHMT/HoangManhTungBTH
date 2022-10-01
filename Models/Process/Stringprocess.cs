namespace HoangManhTungBTH.Models.Process
{
    public class Stringprocess{
    public string RemoveRemainingWhiteSpace (string strInput)
    {
        string result ="";
        // xoa bo ky tu trang o dau va cuoi chuoi
        strInput = strInput.Trim();
        // xoa bo ky tu trang con thua trong chuoi
        int index = strInput.IndexOf("  ");
        while(strInput.IndexOf("  ") > 0){
            strInput = strInput.Replace("  ", " ");
        }
        result = strInput;
        return result;
    }

    public string LowerToUpper (string strInput)
    {
        string strResult = "";
        //tra ve gia tri
        strInput = strInput.ToUpper();
        strResult = strInput;
        return strResult;
    }
    public string UpperToLower (string strInput)
    {
        string strResult= "";
        strResult = strInput.ToUpper();
        strResult = strInput;
        return strResult;
    }
    public string CapitalizeOneFirstCharacter(string strInput)
    {
        string strResult = "";
        // lay ra ki tu dau cua chuoi
        string firstchar = strInput.Substring(0,1).ToUpper();
        strResult = firstchar + strInput.Substring(1);
        return strResult;
    }

    public string CapitalizerOneFirstCharacter(string strInput)
    {
        string HoTen = "hoang manh t"
        //=> gia tri tra ve : "Hoang Manh T"  // => viet hoa chu cai dau tien
        string strResult = "";
        //tach cac tu trong chuoi dua vao 1 mang
        string[] chuoi = strInput.Split(" ");
        // SD vong lap de xu ly tung gia tri trong mang str
        return strResult;
    }
    }
}