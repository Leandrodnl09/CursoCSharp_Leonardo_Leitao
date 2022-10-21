using CursoBasicoAoAvancado.Fundamentos;
using CursoBasicoAoAvancado.EstruturaDeControle;
using CursoBasicoAoAvancado.ClassesEMetodos;
using CursoBasicoAoAvancado.Colecoes;
using CursoBasicoAoAvancado.OO;
using static CursoBasicoAoAvancado.OO.Ferrari;
using CursoBasicoAoAvancado.MetodosEFuncoes;
using CursoBasicoAoAvancado.Excecoes;
using CursoBasicoAoAvancado.Api;
using CursoBasicoAoAvancado.TopicosAvancados;

namespace CursoCSharp
{   
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos;
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimérticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // Estruturas de controle;
                {"Estrutura IF - Estrutura de Controle", EstruturaIF.Executar},
                {"Estrutura IF/ELSE - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE/IF - Estrutura de Controle", EstruturaIFELSEIF.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do/While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura For/Each - Estrutura de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},
                
                //Classes e Métodos;
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos", DesafioAtributos.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct VS Classe - Classes e Métodos", StructVSClasse.Executar},
                {"Valor VS Referência - Classes e Métodos", ValorVSReferencia.Executar},
                {"Parâmentros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmentro Com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},
                
                // Coleções;
                {"Testando Array - Coleções", TestandoArray.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Coleções Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},
                
                // OO;
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
                
                // Métodos e Funções;
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegates.Executar},
                {"Delegate Funções Anônimas - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegate Com Parâmetros - Métodos e Funções", DelegatesComParametros.Executar},
                {"Métodos de Extenções - Métodos e Funções", MetodosDeExtencao.Executar},
                
                // Exceções;
                {"Primeira Exeção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                
                //Api;
                {"Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando Api", LendoArquivos.Executar},
                {"Exemplo File Info - Usando Api", ExemploFileInfo.Executar},
                {"Diretórios - Usando Api", Diretorios.Executar},
                {"Exemplos Directory Info - Usando Api", ExemploDirectoryInfo.Executar},
                {"Exemplos Path - Usando Api", ExemploPath.Executar},
                {"Exemplos DateTime - Usando Api", ExemploDateTime.Executar},
                {"Exemplos TimeSpain - Usando Api", ExemploTimeSpan.Executar},
                
                // Tópicos Avançados;
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamics - Tópicos Avançados", Dynamics.Executar},
                {"Genéricos - Tópicos Avançados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}