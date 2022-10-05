//Criado por Karina Bueno

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;


typedef struct no_st {
	int dados;
	struct no_st *proximo;
}*no; //typedef como se fosse um alias


 no cria_no(int valor) {

  no novoNo = (no)malloc(sizeof(no));
  if (novoNo != NULL)
  {

	  novoNo->dados = valor;
	  novoNo->proximo = NULL;

  }
  return novoNo;
}

 int conta(no lista) {
	 no aux = NULL;
	 int total = 0;

	 for (aux = lista, total = 0; aux != NULL; aux = aux->proximo)
	 {
		 total++;
	 }
	 return total;
 }


int main()
{
	char op;
	no cabeca = NULL;
	no cauda = NULL;
	
	do {

		
		cout <<"[1:insere numero]" << "\n"
			<< "[2:listar]\n"
			<< "[3:remover a posicao]\n" 
			<< "[4:remover o valor inserido]\n"
			<< "\n[0:SAIR]\n"
			<< "Opcao?\n";
			
		cin >> op;//MENU


		switch (op)
		{
		case '1': 
			system("clear");
			no novoNo;
			no aux;
			int novo;
			cout << "inserir um numero\t";
			cin >> novo;
			
			novoNo = cria_no(novo);

			if (cabeca == NULL) // inserir primeiro elemento
			{
				cabeca = novoNo;
				cauda = novoNo;
			}
			else // inserir na cabeca
			{
				if (novoNo ->dados < (cabeca) ->dados)
				{
					novoNo->proximo = cabeca;
					cabeca = novoNo;
				}
				else // inserir na cauda
				{
					if (novoNo ->dados > (cauda) ->dados)
					{
						(cauda)->proximo = novoNo;
						(cauda) = novoNo;
					}
					else // inserir no corpo
					{
						for (aux = cabeca; aux->proximo->dados < novoNo->dados; aux = aux->proximo)
						{

						}

						novoNo->proximo = aux->proximo;
						aux->proximo = novoNo;
						
					}


					
				}

			}

									
			break;
		case '2': 
			//listar
			system("clear");
			cout << "valor da Lista:\t";
			aux = NULL;
			for (aux = cabeca; aux!=NULL; aux = aux->proximo)
			{
				cout <<","<<(aux->dados);
			}

			cout << "\nTotal de elementos: " << conta(cabeca)<<"\n";

			break;

		case '3':
			//remover posicao

		    int a_remover;
		
			int aux_pos;
			system("clear");
			cout << "Introduza a posicao a remover da lista: ";
			cin >> a_remover;

			
			
			// === A LISTA ESTA VAZIA ====
			if (cabeca == NULL) {
				return -1;
			}
			else {
				// === A POSICAO É INVÁLIDA ===
				if (a_remover < 1 || a_remover > conta(cabeca)) {
					return -2;
				}
				else {
					if (conta(cabeca) == 1) {
						// === REMOÇÃO DO UNICO ELEMENTO DA LISTA ===
						cabeca = NULL;
						cauda = NULL;
					}
					else {
						// === REMOÇÃO NA CABEÇA
						if (a_remover == 1) {
							cabeca = cabeca->proximo;
						}
						else {
							if (a_remover == conta(cabeca)) {
								// === REMOCAO NA CAUDA ===                        
								aux = cabeca;
								for (aux_pos = 1; aux_pos < a_remover - 1; aux_pos++) {
									aux = aux->proximo;
								}
								aux->proximo = NULL;
							}
							else {
								// === REMOÇÃO NO CORPO ===
								aux = cabeca;
								for (aux_pos = 1; aux_pos < a_remover - 1; aux_pos++) {
									aux = aux->proximo;
								}
								aux->proximo = aux->proximo->proximo;
							}
						}
					}
				}
			}
			
			break;
		case'4':

			//remover posicao

			int removValor;

			int aux_Valor;
			system("clear");
			cout << "Introduza a posicao a remover da lista: ";
			cin >> removValor;



			// === A LISTA ESTA VAZIA ====
			if (cabeca == NULL) {
				return -1;
			}
			else {
				// === A POSICAO É INVÁLIDA ===
				if (removValor < 1 || removValor > conta(cabeca)) {
					return -2;
				}
				else {
					if (cauda == cabeca) {
						// === REMOÇÃO DO UNICO ELEMENTO DA LISTA ===
						cabeca = NULL;
						cauda = NULL;
						free(cabeca);
					}
					else {
						// === REMOÇÃO NA CABEÇA
						if (cabeca->dados== removValor) {
							aux = cabeca;
							cabeca = cabeca->proximo;
							free(aux);
						}
						else {
							if (cauda->dados== removValor) {
								// === REMOCAO NA CAUDA ===                        
								aux = cabeca;
								for (aux->proximo != cauda) {
									aux = aux->proximo;
								}
								cauda = aux;
								free(cauda->proximo);
								cauda->proximo = NULL;
							}
							else {
								// === REMOÇÃO NO CORPO ===
								aux = cabeca;
								for (aux->proximo->dados< removValor) {
									aux = aux->proximo;
								}
								removValor = aux->proximo;
								aux->proximo = removValor->proximo;
								free(removValor);

							}
						}
					}
				}
			}




			break;
			
			
		default:
			break;
		}
		

		cout << "\n\n\n\nObrigado por usar a nossa aplicacao.\n\n\n";

	} while (op !=0);

	
	return 0;
}



