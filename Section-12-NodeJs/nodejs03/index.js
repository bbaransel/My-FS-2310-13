const http = require("node:http");
const server = http.createServer((request, response) => {
    if (request.url == "/") {
        response.write("<h1>Welcome!</h1>")
        response.end();
    } else if (request.url == "/products") {
        response.write("<h1>Products Home Page</h1>")
        response.end();
    } else if (request.url == "/categories") {
        response.write("<h1>Categories Home Page</h1>")
        response.end();
    } else {
        response.write("<h1>404 Not Found</h1>")
        response.end();
    }
})
server.listen(3000);
console.log("Server 3000 portundan ayağa kalktı");
console.log("http://localhost:3000 linkinden ulaşabilirsiniz.")