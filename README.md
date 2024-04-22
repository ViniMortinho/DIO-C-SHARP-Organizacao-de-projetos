# C SHARP > DIO - ORGANIZAÇÃO DE PROJETO

---

# Organizão de Projetos em C Sharp

![Microsoft](https://img.shields.io/badge/Microsoft-0078D4?style=for-the-badge&logo=microsoft&logoColor=white)![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

## Descrição

A organização adequada do projeto é crucial para manter o código limpo e gerenciável. Aqui estão algumas diretrizes:

Estrutura de Diretório: Mantenha uma estrutura de diretório clara e consistente. Normalmente, você pode ter diretórios separados para modelos (Models), controladores (Controllers), visões (Views), serviços (Services), e assim por diante.
Nomeação: Use convenções de nomenclatura consistentes e significativas para classes, métodos, variáveis e arquivos.
Separação de Responsabilidades: Cada classe ou método deve ter uma única responsabilidade. Isso torna o código mais fácil de manter e testar.

## Arquivos de Projetos em C#

Todo projeto vai conter dois arquivos chamados:

- **.csproj**: Contém informações referentes a um projeto (buil,debug,versão)
- **.sln**: Contém informações que carregam um agrupamento de projetos

Temos três programas que rodam dentro de uma mesma solution.
para evitar que se manipule ou se automatize as duas duas pastas a cada movimentação criamos uma terceira pasta chamada common
que comunica as duas dentro da.sln
Isso impede duplicação de codigo e melhora o gerenciamento das infomações e leitura dos dados nela contida
O projeto **Common** serve como projeto referencia base dos demais dentro da **.sln** neste caso de movimentações financeiras.
lembrando que não há limite de projetos para uma **.sln**

## Criando uma **.sln**

`dotnet "new" "sln" "-n" "NomeDoprojeto" "-o"`

## FORMAÇÃO.NET DA [DIO](https://dio.me/curso-dot-net/AFY84PUWVGH8)

---

## REQUISITOS

- (global::System.Object https, global::System.Object item2) = (https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/download)
- [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

## Introdução

##Eu gostaria de agradecer ao professor do curso, Leonardo Buta, por compartilhar seus conhecimentos e experiências sobre o desenvolvimento.NET.
Ele é um desenvolvedor.NET sênior e um tech expert da DIO, Eu aprendi muito com as suas aulas e espero continuar me aperfeiçoando nessa área. Muito obrigado, Buta!
[Leonardo Buta](https://github.com/leonardobuta)
```Espero que isso ajude! Se você precisar de quaisquer outras conversões ou informações, por favor, me avise.Espero que isso ajude! Se você precisar de quaisquer outras conversões ou informações, por favor, me avise.
