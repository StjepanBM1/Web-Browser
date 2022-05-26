DOTNET = dotnet
MCS = mcs

all: dotnet
mono: copy cs run

dotnet:
	@$(DOTNET) run --project src
	rm -rf src/bin

clean:
	rm -rf mono

copy:
	rm -rf mono
	@mkdir mono
	@cp src/Program.cs mono/Program.cs
	@cp src/Terminal.cs mono/Terminal.cs

cs:
	@$(MCS) mono/Program.cs mono/Terminal.cs

run:
	@mono mono/Program.exe