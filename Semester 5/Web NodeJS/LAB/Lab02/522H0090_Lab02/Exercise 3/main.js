const http = require('http');
const url = require('url');

let students = new Map();
students.set(1, { id: 1, name: 'Nguyen Van A' });
students.set(2, { id: 2, name: 'Nguyen Van B' });

const server = http.createServer((req, res) => {
    const parsedUrl = url.parse(req.url, true);
    const pathname = parsedUrl.pathname;

    if (pathname === '/students') {
        if (req.method === 'GET') {
            res.writeHead(200, { 'Content-Type': 'application/json' });
            return res.end(JSON.stringify([...students.values()]));
        } else if (req.method === 'POST') {
            let body = '';
            req.on('data', data => {
                body += data.toString();
            });
            req.on('end', () => {
                let newStudent = JSON.parse(body);
                let newId = students.size + 1;
                newStudent.id = newId;
                students.set(newId, newStudent);
                res.writeHead(201, { 'Content-Type': 'application/json' });
                return res.end(JSON.stringify(newStudent));
            });
            return;
        }
    }

    const studentPattern = /^\/students\/(\d+)$/;
    const match = pathname.match(studentPattern);
    if (match) {
        const studentId = parseInt(match[1]);  
        if (students.has(studentId)) {
            if (req.method === 'GET') {
                res.writeHead(200, { 'Content-Type': 'application/json' });
                return res.end(JSON.stringify(students.get(studentId)));
            } else if (req.method === 'PUT') {
                let body = '';
                req.on('data', chunk => {
                    body += chunk.toString();
                });
                req.on('end', () => {
                    let updatedStudent = JSON.parse(body);
                    updatedStudent.id = studentId;
                    students.set(studentId, updatedStudent);
                    res.writeHead(200, { 'Content-Type': 'application/json' });
                    return res.end(JSON.stringify(updatedStudent));
                });
                return;
            } else if (req.method === 'DELETE') {
                students.delete(studentId);
                res.writeHead(200, { 'Content-Type': 'application/json' });
                return res.end(JSON.stringify({ message: `Student ${studentId} deleted` }));
            }
        } else {
            res.writeHead(404, { 'Content-Type': 'application/json' });
            return res.end(JSON.stringify({ error: 'Student not found' }));
        }
    }

    res.writeHead(404, { 'Content-Type': 'application/json' });
    return res.end(JSON.stringify({
        message: 'Invalid URL'
    }));
});

server.listen(8080, () => {
    console.log('Server running at http://localhost:8080/');
});
