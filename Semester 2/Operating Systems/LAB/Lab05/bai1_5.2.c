#include <sys/types.h>

#include <stdio.h>

#include <string.h>

#include <unistd.h>

#define BUFFER_SIZE 25
#define READ_END 0
#define WRITE_END 1
int main(int argc, char ** argv) {
  if(argc > 2)
    printf("Truyen qua nhieu tham so");
  else if(atoi(argv[1]) < 4)
    printf("So truyen vao phai lon hon 3");
  else if(atoi(argv[1]) == 0)
    printf("Loi truyen tham so");
  else
  {
    int fd[2];   // Đường ống gửi đi
    int fe[2];  // Đường ống nhận về
    pid_t pid;
    int Giaithua = 1;  // khai báo biến chứa giá trị giai thừa
    /* create the pipe */
    if (pipe(fd) == -1) {
      fprintf(stderr, "Pipe failed");
      return 1;
    }
    // Khởi tạo đường ống thứ hai, đặt tên là fe (tên khác cũng được)
    /* create the pipe*/
    if(pipe(fe) == -1)
    {
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
    if (pid > 0)
    {
      /* parent process */
      // Gửi chuỗi kí số n vào đường ống thứ nhất fd
      // write_msg sẽ thay bằng ???
      /* close the unused end of the pipe */
      close(fd[READ_END]);
      /* write to the pipe */
      write(fd[WRITE_END], argv[1], strlen(argv[1] + 1));
      /* close the write end of the pipe */
      close(fd[WRITE_END]);
      // chờ 1 giây cho tiến trình con xử lý.
      sleep(1);
      // đọc đường ống thứ hai fe
      read((fe[READ_END]), &Giaithua, sizeof(Giaithua));
      // in n! ra màn hình
      printf("\n%s! = %d", argv[1], Giaithua);
      // chờ đợi con kết thúc
    }
    else
    {
      /* child process */
      /* close the unused end of the pipe */
      close(fd[WRITE_END]);
      /* read from the pipe */
      read(fd[READ_END], argv[1], BUFFER_SIZE);
      printf("read %s", argv[1]);
      /* close the read end of the pipe */
      close(fd[READ_END]);
      // chuyển chuỗi nhận thành giá trị số.
      int n = atoi(argv[1]);
      // tính giá trị n!
      for(int i = 1; i <= n; i++)
      {
        Giaithua = Giaithua * i;
      }
      // gửi giá trị n! đã tính vào đường ống thứ hai fe
      write(fe[WRITE_END], &Giaithua, sizeof(Giaithua));
      // kết thúc con.
    }
  }
    return 0;
}