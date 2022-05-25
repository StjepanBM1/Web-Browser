CC = mcs

all: cs run clean

cs:
	@$(CC) src/main.cs src/Terminal.cs

run:
	@mono src/main.exe
	
clean:
	@cd src
	@rm -rf *.exe
	@cd ../