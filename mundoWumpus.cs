using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class fase{

	//static List<Employee> employees = new List<Employee>();
	//ArrayList mapa = new ArrayList(); //inicializa arrayList
	List<Sala> mapa = new List<Sala>();
	
	private void preencheSala(ArrayList mapa){ //função para colocar nome nas 
		
		mapa.Insert(0, new Sala("00", false, false, false, true));
		mapa.Insert(1,new Sala("01", false, false, false, false));
		mapa.Insert(2, new Sala("02", false, false, false, false));
		mapa.Insert(3, new Sala("03", false, false, false, false));
		mapa.Insert(4, new Sala("10", false, false, false, false));
		mapa.Insert(5, new Sala("11", false, false, false, false));
		mapa.Insert(6, new Sala("12", false, false, false, false));
		mapa.Insert(7, new Sala("13", false, false, false, false));
		mapa.Insert(8, new Sala("20", false, false, false, false));
		mapa.Insert(9, new Sala("21", false, false, false, false));
		mapa.Insert(10, new Sala("22", false, false, false, false));
		mapa.Insert(11, new Sala("23", false, false, false, false));
		mapa.Insert(12, new Sala("30", false, false, false, false));
		mapa.Insert(13, new Sala("31", false, false, false, false));
		mapa.Insert(14, new Sala("32", false, false, false, false));
		mapa.Insert(15, new Sala("33", false, false, false, false));
	}

	public void defineWumpus(ref List<Sala> mapa){
		Random rnd = new Random();
		int defineSala = rnd.Next(0, 16);
		mapa[defineSala].setWumpus(true);
	}
	public void defineOuro(ref List<Sala> mapa){
		Random rnd = new Random();
		int defineSala = rnd.Next(0, 16);
		mapa[defineSala].setOuro(true);
	}
	public void definePoco(ref List<Sala> mapa){ //definido randomicamente
	//função para definir o local dos poços e automaticamente já define onde estará a brisa
		int i=0;
		int defineSala = 0;
		while(i<3){
			Random rnd = new Random();
			defineSala = rnd.Next(0, 16);
			if((mapa[defineSala].getOuro()!=true)&&(mapa[defineSala].getWumpus()!=true)){ //pro ouro não começar no poço
				mapa[defineSala].setPoco(true);
				i=i+1;
			}
		}
	}
}
public class Sala{
	public bool jogador;
	public string nomeSala;
	public bool ouro;
	public bool wumpus;
	public bool poco;

	public Sala(string nomeSala, bool ouro, bool wumpus, bool poco, bool jogador){
		this.nomeSala = nomeSala;
		this.ouro = ouro;
		this.wumpus = wumpus;
		this.poco = poco;
		this.jogador = jogador;
	}
	public bool getJogador(){
		return jogador;
	}
	public void setJogador(bool jogador){
		this.jogador = jogador;
	}
	public bool getPoco(){
		return poco;
	}
	public void setPoco(bool poco){
		this.poco = poco;
	}
	public string getNomeSala(){
		return nomeSala;
	}
	public void setNomeSala(string nomeSala){
		this.nomeSala = nomeSala;
	}
	public bool getOuro(){
		return ouro;
	}
	public void setOuro(bool ouro){
		this.ouro = ouro;
	}
	public bool getWumpus(){
		return wumpus;
	}
	public void setWumpus(bool wumpus){
		this.wumpus = wumpus;
	}

}
public class jogador{
	public bool estado = true;
	public int posicaoAtual = 0;
	public bool flecha = true; //indica se eu ainda tenho a flecha ou se já gastei
	public int pontuacao = 0;
	public List<Sala> salasDescobertas = new List<Sala>(); //define tudo que já foi descoberto pelo personagem
	public int numAcoes = 0;
	public bool ouro = false;
	public int angulo;

	public void caminharNoMapa(){
		while( (getOuro() == false) || (getEstado() == true)){
			//enquanto eu não tiver o ouro, ou estiver vivo -- 
			if( mapa[getPosicaoAtual()].getWumpus() == true ){ //fim do jogo
				Console.Write("\nGame Over você morreu !\n");
				break;
			} 
			else if( mapa[getPosicaoAtual()].getOuro() == true ){ //fim do jogo pego o ouro
				Console.Write("\n Você conseguiu pegar o ouro ! Fim de jogo, sua pontuação foi de "+ getPontuacao() + '\n');
				break;
			}
			else{ //verifico quais são as informações que eu tenho para tomar uma decisão

			}

		}
	}

	public void medidaDesempenho(int pontuacao){
		if(getFlecha()==false){
			this.pontuacao = pontuacao - 10;
		}
		if(getOuro()==true){
			this.pontuacao = pontuacao + 1000;
		}
		if(getEstado()==false){
			this.pontuacao = pontuacao - 1000;
		}
		int aux = contAcoes();
		pontuacao = pontuacao + aux;
	}
	public int getAngulo(){
		return angulo;
	}
	public void setAngulo(int angulo){
		this.angulo = angulo;
	}
	public bool getOuro(){
		return ouro;
	}
	public void setOuro(bool ouro){
		this.ouro = ouro;
	}
	public int contAcoes(){
		return this.numAcoes = this.numAcoes + 1;
	}
	public void setEstado(bool estado){ //vai ser o meu equivalente a mandar a flecha
		this.estado = false;
	}
	public bool getEstado(){
		return estado;
	}
	public bool getFlecha(){
		return flecha;
	}
	public void setFlecha(bool flecha){ //vai ser o meu equivalente a mandar a flecha
		this.flecha = false;
	}
	public int getPontuacao(){
		return pontuacao;
	}
	public void setPontuacao(int pontuacao){
		this.pontuacao = pontuacao;
	}
	public void setPosicaoAtual(int posicaoAtual){
		this.posicaoAtual = posicaoAtual;
	} 

}
class main{

	public static void Main(){

	}
}