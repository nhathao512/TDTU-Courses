const express = require('express');
const router = express.Router();
const { body, validationResult } = require('express-validator');
const UserAPI = require('../user');

router.get('/', async (req, res) => {
    try {
        const users = await UserAPI.getUsers();
       
        res.render('user-list', { users });
    } catch (error) {
        console.error('Error retrieving users:', error);
        res.status(500).send('Error retrieving users');
    }
});

router.get('/:id', async (req, res) => {
    try {
        const user = await UserAPI.getUserById(req.params.id);
        if (!user) {
            return res.status(404).send('User not found');
        }
        res.render('user-detail', { user });
    } catch (error) {
        res.status(500).send('Error retrieving user details');
    }
});

router.post('/', 
    body('name').isString().notEmpty(),
    body('email').isEmail(),
    async (req, res) => {
        const errors = validationResult(req);
        if (!errors.isEmpty()) {
            return res.status(400).json({ errors: errors.array() });
        }

        try {
            const newUser = await UserAPI.addUser(req.body);
            res.redirect('/users');
        } catch (error) {
            res.status(500).send('Error adding user');
        }
    }
);

module.exports = router;
