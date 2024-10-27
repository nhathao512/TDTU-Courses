const https = require('https');

// Hàm lấy danh sách người dùng
function getUsers() {
    return new Promise((resolve, reject) => {
        const options = {
            hostname: 'web-nodejs-502070-wiolshzi6q-uc.a.run.app',
            path: '/students',
            port: 443,
            method: 'GET'
        };

        const req = https.request(options, (res) => {
            let data = '';
            res.on('data', (chunk) => data += chunk);
            res.on('end', () => {
                resolve(JSON.parse(data)); // Chuyển đổi chuỗi JSON thành object
            });
        });

        req.on('error', (err) => reject(err));
        req.end();
    });
}

function getUserById(userId) {
    return new Promise((resolve, reject) => {
        const options = {
            hostname: 'web-nodejs-502070-wiolshzi6q-uc.a.run.app',
            path: `/students/${userId}`,
            port: 443,
            method: 'GET'
        };

        const req = https.request(options, (res) => {
            let data = '';
            res.on('data', (chunk) => data += chunk);
            res.on('end', () => resolve(JSON.parse(data)));
        });

        req.on('error', (err) => reject(err));
        req.end();
    });
}

function addUser(user) {
    return new Promise((resolve, reject) => {
        const options = {
            hostname: 'web-nodejs-502070-wiolshzi6q-uc.a.run.app',
            path: '/students',
            port: 443,
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            }
        };

        const req = https.request(options, (res) => {
            let data = '';
            res.on('data', (chunk) => data += chunk);
            res.on('end', () => resolve(JSON.parse(data)));
        });

        req.on('error', (err) => reject(err));
        req.write(JSON.stringify(user));
        req.end();
    });
}

module.exports = { getUsers, getUserById, addUser };
