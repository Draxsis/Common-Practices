const express = require('express');
const router = express.Router();
const { register, login } = require('../controllers/authController');

router.use(express.json());

// User registration
router.post('/register', register);

// User login
router.post('/login', login);

module.exports = router;
