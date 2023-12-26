const jwt = require('jsonwebtoken');


const secretKey = "SToken";

function extractBearerToken(header) {
  if (typeof header !== 'string') {
    return null;
  }

  const parts = header.split(' ');
  if (parts.length === 2 && parts[0] === 'Bearer') {
    return parts[1];
  }

  return null;
}

function authenticateToken(req, res, next) {
  const header = req.header('Authorization');

  if (!header) {
    return res.status(401).json({ message: 'Unauthorized' });
  }

  const token = extractBearerToken(header);

  if (!token) {
    return res.status(401).json({ message: 'Invalid token format' });
  }

  jwt.verify(token, secretKey, (err, user) => {
    if (err) {
      console.error('Error verifying token:', err);
      return res.status(403).json({ message: 'Forbidden' });
    }

    req.user = user;
    next();
  });
}

module.exports = authenticateToken;
