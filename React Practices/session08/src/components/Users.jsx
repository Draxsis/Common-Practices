import React, { useEffect, useState } from "react";

export default function Users() {
  const [characters, setCharacters] = useState([]);
  const [charactersPerPage, setCharactersPerPage] = useState(3);
  const [currentPage, setCurrentPage] = useState(1);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(
          "https://rickandmortyapi.com/api/character"
        );
        const data = await response.json();
        setCharacters(data.results);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []);

  {
    /* character displyed based of index  */
  }
  const indexOfLastCharacter = currentPage * charactersPerPage;
  const indexOfFirstCharacter = indexOfLastCharacter - charactersPerPage;
  const currentCharacters = characters.slice(
    indexOfFirstCharacter,
    indexOfLastCharacter
  );

  const handlePageChange = (newPage) => {
    setCurrentPage(newPage);
  };

  const handleCharactersPerPageChange = (event) => {
    setCharactersPerPage(parseInt(event.target.value, 10));
    setCurrentPage(1);
  };

  return (
    <>
      {/* character image display */}
      <div
        style={{
          width: "100%",
          margin: "auto",
          display: "flex",
          flexWrap: "wrap",
          justifyContent: "center",
        }}
      >
        {currentCharacters.map((character) => (
          <div
            key={character.id}
            style={{ margin: "10px", textAlign: "center" }}
          >
            <img
              src={character.image}
              alt={character.name}
              width={100}
              height={100}
              style={{ marginBottom: "5px" }}
            />
            <div>{character.name}</div>
          </div>
        ))}
      </div>
      {/* button based on character on each page  */}
      <div style={{ textAlign: "center", marginTop: "20px" }}>
        {Array.from({
          length: Math.ceil(characters.length / charactersPerPage),
        }).map((_, index) => (
          <button key={index} onClick={() => handlePageChange(index + 1)}>
            {index + 1}
          </button>
        ))}
      </div>

      {/* character per page set */}

      <div style={{ textAlign: "center", marginTop: "10px" }}>
        <label htmlFor="charactersPerPage">Characters per page:</label>
        <select
          id="charactersPerPage"
          value={charactersPerPage}
          onChange={handleCharactersPerPageChange}
        >
          {[3, 5, 10, 25].map((value) => (
            <option key={value} value={value}>
              {value}
            </option>
          ))}
        </select>
      </div>
    </>
  );
}
