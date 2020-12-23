### Reviewing your assignment

we need an electronic grade book to read the scores of an individual student and then compute some simple statistics from the scores.
the grades are entered as floating point numbers from 0 to 100, and the statistics should show us the highest grade, the lowest grade, and the average grade.

create test unit with xunit and perform testability.

---
Precisamos de um livro de notas eletrônico para ler as pontuações de um aluno individual e, em seguida, calcular algumas estatísticas simples a partir das pontuações.
as notas são inseridas como números de ponto flutuante de 0 a 100 e as estatísticas devem nos mostrar a nota mais alta, a nota mais baixa e a nota média.

criar unidade de teste com xunit e realizar testability.


Commands
-- mkdir gradebook && cd gradebook
-- mkdir src && mkdir test
-- cd src && mkdir GradeBook && cd GradeBook && dotnet new console
-- dotnet run
-- cd ../../
-- cd test && mkdir GradeBook.Tests && cd GradeBook.Tests && dotnet new xunit
-- dotnet test
-- dotnet add reference src/GradeBook/GradeBook.csproj

-- cd gradebook
-- dotnet new sln
-- dotnet sln add src/GradeBook/GradeBook.csproj
-- dotnet sln add test/GradeBook.Tests/GradeBook.Tests.csproj

-- dotnet build