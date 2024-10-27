const express = require('express');
const rateLimit = require('express-rate-limit');
const app = express();
const userRoutes = require('./routes/users'); 

app.set('view engine', 'ejs');
app.use(express.json()); 

const limiter = rateLimit({
    windowMs: 15 * 60 * 1000, 
    max: 100 
});
app.use(limiter);

app.use('/users', userRoutes);

app.get('/', (req, res) => {
    res.redirect('/users');
});

app.use((req, res) => {
    res.status(404).render('error', { message: '404 - Not Found' });
});

const PORT = 3000;
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
