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

	public void defineWumpus(ArrayList mapa){
		Random rnd = new Random();
		int defineSala = rnd.Next(0, 16);
		mapa[defineSala].setWumpus(true);
	}
	public void defineOuro(ArrayList mapa){
		Random rnd = new Random();
		int defineSala = rnd.Next(0, 16);
		mapa[defineSala].setOuro(true);
	}
	public void definePoco(ArrayList mapa){ //definido randomicamente
	//função para definir o local dos poços e automaticamente já define onde estará a brisa
		int i=0;
		while(i<3){
			Random rnd = new Random();
			int defineSala = rnd.Next(0, 16);
			if(mapa[defineSala].getOuro()!=true){ //pro ouro não começar no poço
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
	
	public int[] posicaoAtual = {0,0};
	public bool flecha = true; //indica se eu ainda tenho a flecha ou se já gastei
	public int pontuacao = 0;
	public ArrayList mapaDescobertos = new ArrayList(); //define tudo que já foi descoberto pelo personagem

		
	public void medidaDesempenho(int pontuacao){

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
	public void setPosicaoAtual(int linha, int coluna, ref int posicaoAtual){
		this.posicaoAtual[0] = linha;
		this.posicaoAtual[1] = coluna;
	} 

}
class main{

	public static void Main(){

	}
}