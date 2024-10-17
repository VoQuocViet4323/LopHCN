public class HCN{
    double width, height;
    public HCN(){}
    public HCN(double width, double height){
        this.width = width;
        this.height = height;
    }
    public double getArea(){
        return width * height;
    }
    public double getPerimeter(){
        return 2 * (width + height);
    }
    public string Display(){
        return "Hình chữ nhật có {chiều rộng= " + width + ", chiều cao= " + height + "}";
    }
}