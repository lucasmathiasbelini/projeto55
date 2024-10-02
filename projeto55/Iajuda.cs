public abstract class Iajuda{
    Button ButtonResposta01;
    Button ButtonResposta02;
    Button buttonResposta03;
    Button buttonResposta04;

    Frame frame1;

    public void ConfiguraEstruturaDesenho(Button ButtonResposta01, Button ButtonResposta02, Button ButtonResposta03, Button ButtonResposta04){
        this.ButtonResposta01 = ButtonResposta01;
        this.ButtonResposta02 = ButtonResposta02;
        this.buttonResposta03 = ButtonResposta03;
        this.buttonResposta04 = buttonResposta04;

    }
    public void ConfiguraEstruturaDesenho(Frame frame1){
        this.frame1 = frame1;
}

}