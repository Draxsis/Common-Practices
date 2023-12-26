const Movie = require("../models/movie.js");

exports.createMovie = async (req, res) => {
  const { name, genre, rate, year } = req.body;
  const movie = new Movie({ name, genre, rate, year });
  await movie.save();
  res.status(201).send("Movie has been created.");
};

exports.getAllMovies = async (req, res) => {
  const movies = await Movie.find();
  res.status(200).json({ count: movies.length, data: movies });
};

exports.getMovieById = async (req, res) => {
  try {
    const movie = await Movie.findById(req.params.id);
 
    return res.status(200).json({ movie });
  } catch (error) {
    console.log(error);
  }
};

exports.getMoviesByYear = async (req, res) => {
  const { year } = req.params;
  const movies = await Movie.find({ year: year });
  res.json(movies);
};

exports.updateMovie = async (req, res) => {
  const { name, genre, rate, year } = req.body;
  const updatedMovie = await Movie.findByIdAndUpdate(
    req.params.id,
    { name, genre, rate, year },
    { new: true }
  );
  res.json(updatedMovie);
};

exports.deleteMovie = async (req, res) => {
  try {
    const deletedMovie = await Movie.findByIdAndDelete(req.data.params.id);
    if (!deletedMovie) {
      return res.status(404).json({ message: "Movie not found" });
    }
    res.status(200).json({ message: "Movie has been deleted successfully" });
  } catch (error) {
    res.status(500).json({ message: "Server error" });
  }
};
