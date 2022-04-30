
CC=mcs

all: cs run

cs:
	@$(CC) main.cs

run:
	@mono main.exe
	
clean:
	rm -rf *.exe
