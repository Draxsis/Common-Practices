// Imports
const express = require("express");
const mongoose = require("mongoose");
const authRoute = require("./routes/auth.js");
const moviesRoute = require("./routes/movies.js");

// express app
const app = express();

// Json parser
app.use(express.json());

// Auth Route
app.use("/api/auth", authRoute);

// Movies Route
app.use("/api/movies", moviesRoute);

// Connect to MongoDB
mongoose
  .connect(
    "mongodb+srv://root:root@cluster0.r7dnu6h.mongodb.net/BookingWebsite?retryWrites=true&w=majority",
    { useNewUrlParser: true, useUnifiedTopology: true }
  )
  .then(() => console.log("Successfully connected to the database"))
  .catch((err) => console.error("Connection to database failed:", err));

// Start the server
const PORT = 3000;
app.listen(PORT, () => console.log(`Server running on port ${PORT}`));
