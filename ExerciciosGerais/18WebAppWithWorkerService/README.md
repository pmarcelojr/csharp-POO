## Proposta do Desafio

Criar um aplicação web como um serviço.

E por que eu deveria implantar aplicativos como um serviço do Windows?

Quando criamos um aplicativo, precisamos hospedá-lo em algum lugar para que os usuários possam acessá-lo. Podemos hospedá-lo no IIS ou como um serviço do Windows. Portanto, a seguir, apresentamos alguns motivos para hospedar aplicativos como um serviço do Windows:

1 - Às vezes, hospedamos nossos aplicativos no IIS, mas não utilizamos todos os recursos do IIS.
 
2 - Se a máquina em que estamos hospedando o aplicativo Web não tiver o IIS ativado ou se o IIS estiver ativado, mas não configurado para hospedar um aplicativo .NET Core.

O .NET Core fornece um modo de implantação chamado SCD (Implantação Independente). Quando publicamos nosso aplicativo como SCD, ele fornecerá o executável do aplicativo, juntamente com as DLLs de runtime do .NET Core.  Isso simplifica muito a criação de um serviço.