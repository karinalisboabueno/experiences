#include <string.h>
#include <cstring>
#include <string>
#include <conio.h>
#include <iostream>
#include <time.h>
#include <locale> // para usar carateres nacionais
#include <iomanip> // para a formatação do output
#include <Windows.h> // para o temporizador ou marca_passo
#include <algorithm> // nova: para usar a transform string function
#include <fstream> // para trabalhar com file
using namespace std;



void intermitencia(int t)
{
	cout << "."; Sleep(t); cout << "."; Sleep(t);
	cout << "."; Sleep(t); cout << "."; Sleep(t);
	cout << "."; Sleep(t); cout << "."; Sleep(t);
	cout << "."; Sleep(t);
}
void beep_erro(char op)
{
	if (op != 27)
	{
		cout << "Opcao incorreta!";
		Beep(440, 1000); //frequência, tempo
		Sleep(500); //tempo
	}
}
void desenha_menu()
{
	system("cls");
	cout << " \nExercício prático - algoritmos\n\n" << endl;
	cout << " (A)crescentar nome no fim \n" << endl;
	cout << " (L)istar ficheiro\n" << endl;
	cout << " Escrever (N)o início do ficheiro\n" << endl;
	cout << " Iniciali(Z)ar ficheiro com 16 nomes\n" << endl;
	cout << " (D)eletar ficheiro\n" << endl;
	cout << " (S)ubstituir nome no ficheiro\n" << endl;
	cout << " (P)rocurar nome no ficheiro\n" << endl;
	cout << " A(J)uda\n" << endl;
	cout << " (C)ontar nomes no ficheiro\n" << endl;
	cout << " (1) Contar a ocorrencia de certo nome\n" << endl;
	cout << " (6) Contar certa substring em todos os nomes do ficheiro\n\n";
	cout << " (7) Inicializar Ficheiro com 4 nomes e 4 idades\n\n";
	cout << " (8) Digite 2 nomes; se existirem informa qual o mais velho\n\n";
	cout << " ESC - sair\n\n\n";
}
void ajuda()
{
	int i;
	for (i = 7; i >= 1; i--)
	{
		system("cls");
		cout << "\n\n\n\n\n\n\t" << "ah!... faça mas é os algoritmos!";
		cout << "\n\n\n\n\t";
		cout << " " << i << "...";
		Sleep(600);
	}
}
void inicializa_ficheiro()
{
	ofstream fpd("lista.txt");
	fpd << "Ana Rita Cunha" << "\n";
	fpd << "Bela Costa Silva" << "\n";
	fpd << "Carlos Alberto Costa" << "\n";
	fpd << "Carlos Serafim Ferreira" << "\n";
	fpd << "Daniel Bastos Gomes" << "\n";
	fpd << "Diogo Silva Ferraz" << "\n";
	fpd << "Elvira Gomes Pendes" << "\n";
	fpd << "Fernanda Maria Silva" << "\n";
	fpd << "Fernando Gomes Barros" << "\n";
	fpd << "Gilherme Alexandre Barros" << "\n";
	fpd << "Hilda Fonseca Silva" << "\n";
	fpd << "José Manuel Carvalho" << "\n";
	fpd << "José Alberto Gomes" << "\n";
	fpd << "Maria Silvéria Bastos" << "\n";
	fpd << "Anabela Bastos Torres" << "\n";
	fpd << "Teodoro Armando Matos" << "\n";
	fpd.close();
	cout << "Inicializado!"; intermitencia(100);
}

bool existe_nome_no_ficheiro(string nome)
{

	ifstream fpl("lista.txt");
	string s;

	if (!fpl)
	{
		return false;
	}

	else {
		while (getline(fpl, s))
		{
			if (s == nome) {
				return true;
			}
		}

		fpl.close();

	}

	return false;
}
string getNome(string s)
{
	int p = s.find("#");
	if (p < 0)
	{
		return " ";
	}
	else
	{
		return s.substr(0, p);
	}

}

int getIdade(string s)
{
	// se existir # devolve parte da idade senão devolve -1
	int p = s.find("#");
	if (p < 0)
	{
		return -1;
	}
	else
	{
		// Converte string em numero inteiro
		return stoi(s.substr(p + 1));
	}
}
int getIdadeByNomeNoFicheiro(string nome)
{

	ifstream fpl("lista.txt");
	string s;

	if (!fpl)
	{
		return NULL;
	}

	else {
		while (getline(fpl, s))
		{
			if (getNome(s) == nome) {
				return getIdade(s);
			}
		}

		fpl.close();

	}

	return NULL;
}
void substitui_nome_no_ficheiro(string nomeaprocurar, string nomenovo)
{
	ifstream fp1("lista.txt");
	ofstream fp2("listatemp.txt"); // ficheiro temporario
	string nomenoficheiro; // variavel que toma o valor da linha

	if (fp2.is_open())
	{
		while (getline(fp1, nomenoficheiro))
		{
			if (nomenoficheiro == nomeaprocurar) {

				fp2 << nomenovo << "\n";
			}
			else
			{
				fp2 << nomenoficheiro << "\n";

			}

		}
		fp1.close();
		fp2.close();

	}


	// fp1("listatemp.txt");
	 //fp2("lista.txt");
	fp1.open("listatemp.txt");
	fp2.open("lista.txt");
	if (fp1.is_open())
	{
		while (getline(fp1, nomenoficheiro))
		{
			fp2 << nomenoficheiro << "\n"; //destruir ficheiro temp

		}
		fp1.close();
		fp2.close();
	}









}



int main()
{
	//locale::global(std::locale(""));
	//1252 é o codepage LATIN1 que parece funcionar para nós (Portugal)
	//1253 Greek, 1255 Hebrew, etc...
	SetConsoleOutputCP(1252);
	SetConsoleCP(1252);
	char op;
	string nome; string s; string nomeaprocurar, nomenovo, nome2;
	int i;



	SetConsoleTitle(TEXT(" - TEXT FILE OPERATIONS - "));



	remove("lista.txt");
	ofstream fpapp("lista.txt");
	fpapp.close();
	do
	{
		desenha_menu();
		op = _getch();
		switch (op)
		{



		case '1':
		{
			int contador = 0;
			cout << "Digite o nome a ser procurado \n";
			getline(cin, nome);



			if (existe_nome_no_ficheiro(nome))
			{
				contador++;
				cout << "Existe " << contador << " ocorrencias deste nome!\n";
			}
			else
			{
				cout << "Não existe esse nome no ficheiro";
			}



			intermitencia(200);
			break;
		}




		case '6':
		{
			int contador = 0;
			ifstream fpl("lista.txt");
			cout << "\n";
			cout << "Insira um nome a procurar ou substring";
			cout << "\n";
			getline(cin, nome);



			if (!fpl) //if (!getline(fpl, s))
			{
				cout << "Ficheiro vazio ou inexistente!";

			}
			else 
			{
				while (getline(fpl, s))
				{
					//procura a posicao e ser diferente de null
					if (s.find(nome) != string::npos)
					{
						contador++;
					}



				}

				cout << "Existem " << contador << " nomes no ficheiro!";
				fpl.close();



			}

			system("pause");


			break;
		}
		case '7':
		{
			ofstream fp("lista.txt", ofstream::out);
			fp << "Ana#12\n";
			fp << "Rui#15\n";
			fp << "Maria#16\n";
			fp << "Pedro#17\n";
			fp.close();
			cout << "Inicializado!";


			intermitencia(100);
			break;
		}
		case '8':
		{
			ifstream fp("lista.txt");
			cout << "\n";
			cout << "Insira um nome";
			cout << "\n";
			getline(cin, nome);

			int idade1 = getIdadeByNomeNoFicheiro(nome);

			cout << "Insira outro nome";
			cout << "\n";
			getline(cin, nome2);

			int idade2 = getIdadeByNomeNoFicheiro(nome2);

			if (idade1 == NULL || idade2 == NULL) {
				cout << "Nomes não encontrados";

			}
			else {

				if (idade1 > idade2) {
					cout << nome << " é mais velho que o " << nome2;
				}
				else {
					cout << nome2 << " é mais velho que o " << nome;
				}
			}





			intermitencia(200);

			break;
		}



		case 'a': case 'A': // ----------------------------------------- append
		{
			ofstream fp("lista.txt", ofstream::app);
			cout << "Digite um nome \n";
			getline(cin, nome);
			fp << nome << "\n";



			fp.close();



			intermitencia(100);
			break; }



		case 'l': case 'L': // ----------------------------------------- lista
		{
			system("cls");
			ifstream fpl("lista.txt");
			cout << "\n";



			if (!fpl) //if (!getline(fpl, s))
			{
				cout << "Ficheiro vazio ou inexistente!";
				intermitencia(100);
			}
			else {
				while (getline(fpl, s))
				{
					cout << s << endl;
				}
				fpl.close();
				intermitencia(400);
			}
			break;
		}
		case 'n': case 'N': // ----------------------------------------- escreve no início
		{
			ofstream fp("lista.txt", ofstream::out);



			cout << "Digite um nome \n";
			getline(cin, nome);

			fp << nome << "\n";



			fp.close();



			intermitencia(100);
			break;
		}
		case 'z': case 'Z': // ----------------------------------------- inicializa file
		{
			inicializa_ficheiro();
			break;
		}



		case 'c': case 'C'://-------------------------------------------- contar elementos
		{
			int contador = 0;
			ifstream fpl("lista.txt");
			cout << "\n";



			if (!fpl) //if (!getline(fpl, s))
			{
				cout << "Ficheiro vazio ou inexistente!";
				intermitencia(100);
			}
			else {
				while (getline(fpl, s))
				{
					contador++;
				}
				cout << "Existem " << contador << " nomes no ficheiro!";
				fpl.close();
				intermitencia(400);
			}



			intermitencia(100);
			break;
		}





		case 'd': case 'D': // ----------------------------------------- apaga ficheiro



			if (remove("lista.txt") != 0)
			{
				cout << "não existe ficheiro para remover";



			}
			else
			{
				cout << "removido!";
			}



			intermitencia(100);
			break;



		case 's':case 'S':
		{

			ifstream fpl("lista.txt");
			cout << "\n";
			cout << "Insira o nome a ser substituido";
			cout << "\n";
			getline(cin, nomeaprocurar);

			if (!existe_nome_no_ficheiro(nomeaprocurar))
			{
				cout << "Não existe!...";
			}
			else
			{
				cout << "Insira o novo nome";
				cout << "\n";
				getline(cin, nomenovo);
				substitui_nome_no_ficheiro(nomeaprocurar, nomenovo);

				cout << "Trocado!";
			}



			intermitencia(200);
			break;
		}
		case 'p':case'P': //----------------------------------- existe nome?
		{

			cout << "Digite um nome \n";
			getline(cin, nome);



			if (existe_nome_no_ficheiro(nome))
			{
				cout << "existe!...";
			}
			else
			{
				cout << "não existe";
			}

			intermitencia(100);

			break;
		}
		case 'j': case'J': //----------------------------------- ajuda
		{
			ajuda();
			break;
		}
		case 'k': case 'K':
		{



			intermitencia(50);
			break;
		}
		default: // -------------------------------------------- default
		{
			beep_erro(op);
		}
		}
		} while (op != 27);
		cout << "\t Até breve.";
		intermitencia(50);
	}






