const express = require("express");
const authenticateToken = require("../middlewares/authenticateToken");
const {
  deleteMovie,
  updateMovie,
  createMovie,
  getMovieById,
  getAllMovies,
  getMoviesByYear,
} = require("../controllers/moviesController.js");

const router = express.Router();


// Apply authentication middleware to protected routes
router.get("/", authenticateToken, getAllMovies);
router.get("/:year", authenticateToken, getMoviesByYear);
router.get("/id/:id", authenticateToken, getMovieById);
router.put("/:id", authenticateToken, updateMovie);
router.delete("/:id", authenticateToken, deleteMovie);

// Create a movie (no authentication needed for creation)
router.post("/", createMovie);

module.exports = router;
