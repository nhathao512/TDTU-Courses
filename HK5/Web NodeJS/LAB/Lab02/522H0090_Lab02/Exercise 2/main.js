const http = require('http');
const URL = require('url');
const queryString = require('querystring');
const fs = require('fs');
const path = require('path')

const server = http.createServer((req, res) => {
    res.writeHead(200, {
        'Content-Type': 'text/html; charset=utf-8'
    })

    let { pathname, _ } = URL.parse(req.url, true);

    if (pathname === '/') {
        let html = fs.readFileSync(path.join(__dirname, '/login.html'))
        return res.end(html)
    }
    else if (pathname === '/login') {
        return processLogin(req, res)
    }

    let html = fs.readFileSync(path.join(__dirname, '/error.html')).toString().replace('replace', 'Invalid Path');
    return res.end(html)

});

function processLogin(req, res) {
    let fail = fs.readFileSync(path.join(__dirname, '/error.html')).toString();
    if (req.method !== 'POST') {
        return res.end(fail.replace('replace', `Method ${req.method} is not supported`))
    }

    let string = '';
    req.on('data', data => string += data.toString());
    req.on('end', () => {
        let { inputEmail, inputPassword } = queryString.decode(string);

        if (!inputEmail) {
            return res.end(fail.replace('replace', `Email không hợp lệ`))
        }
        if (!inputPassword) {
            return res.end(fail.replace('replace', `Mật khẩu không hợp lệ`))
        }
        if (!inputEmail && !inputPassword) {
            return res.end(fail.replace('replace', `Email và mật khẩu không hợp lệ`))
        }
        if (inputPassword < 6) {
            return res.end(fail.replace('replace', `Mật khẩu có ít nhất 6 từ`))
        }
        if (inputEmail !== 'admin@gmail.com') {
            return res.end(fail.replace('replace', `Tên người dùng không đúng`))
        }
        if (inputPassword !== '123456') {
            return res.end(fail.replace('replace', `Mật khẩu không đúng`))
        }

        return res.end(fs.readFileSync(path.join(__dirname, '/success.html')));
    })
}

server.listen(8080, () => {
    console.log('Server is running at http://localhost:8080');
});