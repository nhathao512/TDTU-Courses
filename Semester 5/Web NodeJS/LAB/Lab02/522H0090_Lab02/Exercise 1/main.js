const http = require("http")
const queryString = require("querystring")
const URL = require("url");

const server = http.createServer((req, res) => {
    let url = URL.parse(req.url)

    res.writeHead(200, {
        'Content-Type': 'text/html charset=utf-8'
    })

    if (url.pathname == '/') {
        return res.end(`<!DOCTYPE html>
        <html lang="en">
        <head>
            <meta charset="UTF-8">
            <meta name="viewport" content="width=device-width, initial-scale=1.0">
            <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
            <title>Exercise 1</title>
        </head>
        <body>
            <form action="/result" method="get">
                <table class="table-hover">
                    <tr>
                        <td>Số hạng 1</td>
                        <td><input type="text" name="num1" id="num1"></td>
                    </tr>
                    <tr>
                        <td>Số hạng 2</td>
                        <td><input type="text" name="num2" id="num2"></td>
                    </tr>
                    <tr>
                        <td>Phép tính</td>
                        <td>
                            <select name="pheptinh" id="pheptinh">
                                <option value="">Chọn phép tính</option>
                                <option value="+">Cộng</option>
                                <option value="-">Trừ</option>
                                <option value="*">Nhân</option>
                                <option value="/">Chia</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><button type="submit" class="btnTinh">Tính</button></td>
                    </tr>
                </table>
            </form>
            
        </body>
        </html>`
        )
    }
    else if (url.pathname == '/result') {
        let { num1, num2, pheptinh } = queryString.decode(url.query)
        num1 = parseInt(num1)
        num2 = parseInt(num2)

        if (!num1) {
            return res.end("Invalid first parameter")
        }
        if (!num2)
        {
            return res.end("Invalid second parameter")
        }
        if (!pheptinh)
        {
            return res.end("Invalid Operator")
        }

    
        let result = undefined

        switch (pheptinh) {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
        }
        return res.end(`Result: ${num1} ${pheptinh} ${num2} = ${result}`);
    }
    res.end('Đường dẫn không hợp lệ')
})
server.listen(8080, () => {
    console.log("Server is running");
})



