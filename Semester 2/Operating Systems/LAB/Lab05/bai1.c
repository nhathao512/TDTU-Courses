#include <sys/types.h>

#include <stdio.h>

#include <string.h>

#include <unistd.h>

#define READ_END 0
#define WRITE_END 1
int main(int argc, char ** argv) {
  int fd[2];
  pid_t pid;
  /* create the pipe */
  if (pipe(fd) == -1) {
    fprintf(stderr, "Pipe failed");
    return 1;
  }
  /* fork a child process */
  pid = fork();
  if (pid < 0) {
    /* error occurred */
    fprintf(stderr, "Fork Failed");
    return 1;
  }
  if (pid > 0) {
    /* parent process */
    /* close the unused end of the pipe */
    close(fd[READ_END]);
    //đóng đầu đọc
    /* write to the pipe */
    int i;
    for (i = 1; i < argc; i++) {
        write(fd[WRITE_END], argv[i], strlen(argv[i])+1);
        printf("Parent send %s\n", argv[i]);
		sleep(1);  //chờ 1 lát
	    // đóng đầu đọc
 	}
    /* close the write end of the pipe */
    close(fd[WRITE_END]);
    // đóng đầu ghi
    // chờ tiến trình con
  } else {
    /* child process */
    /* close the unused end of the pipe */
    close(fd[WRITE_END]);
    // đóng đầu ghi
    /* read from the pipe */
    char buff[256];
    while (read(fd[READ_END], buff, sizeof(buff)) > 0)
      {
        printf("Read child = %s\n", buff);
	    // đóng đầu ghi
      }
    /* close the read end of the pipe */
    close(fd[READ_END]);
    // đóng đầu đọc
  }
  return 0;
}