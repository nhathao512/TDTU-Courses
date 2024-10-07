public interface VoNhatHao_FractionI 
{
    public int getNumer(); 
    public int getDenom(); 
    public void setNumer(int numer); 
    public void setDenom(int denom); 
    public VoNhatHao_FractionI add(VoNhatHao_FractionI f); 
    public VoNhatHao_FractionI minus(VoNhatHao_FractionI f); 
    public VoNhatHao_FractionI times(VoNhatHao_FractionI f); 
    public VoNhatHao_FractionI simplify(); 
}