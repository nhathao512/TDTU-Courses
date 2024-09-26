const http = require("http");
const fs = require("fs");
const server = http.createServer((req, res) => {
    if (req.url === "/") {
        fs.readFile("index.html", "utf-8", (err, data) => {
            if (err) {
                res.writeHead(500, { "Content-Type": "text/plain" }); 
                res.end("500 Internal Server Error");
            } else {
                res.writeHead (200, { "Content-Type":  "text/html"});
                res.end(data);
            }
        });
    } else if (req.url === "/image.jpg") {
        fs.readFile("image.jpg", (err, data) => {
            if (err) {
                res.writeHead (404, {"Content-Type": "text/plain" }); 
                res.end("404 File Not Found");
            } else {
                res.writeHead (200, { "Content-Type":  "image/jpg"});
                res.end(data);
            }
        });
    } else {
        res.writeHead (404, { "Content-Type": "application/json" });
        const msg = { error: 1, message: "The path is not supported" }; 
        res.end(JSON.parse(msg));
        }
});

const port = 3000;
server.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});