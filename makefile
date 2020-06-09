
all: clean restore build compile #run

clean:
	dotnet clean
	rm *.exe

restore:
	dotnet restore

build: 
	dotnet build

compile:
	csc -out:PartA.exe PartA\Program1.cs DataLayer\IterateNumbers.cs
	csc -out:PartB.exe PartB\Program2.cs DataLayer\IterateNumbers.cs

run:
	dotnet run