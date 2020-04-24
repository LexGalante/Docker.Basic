const express = require('express');
const app = express();
const os = require("os");

app.get('/', (req, res) => {
    res.send(`Hostname: ${os.hostname()}, Version: ${os.version}`);
});

app.listen(80, '0.0.0.0');