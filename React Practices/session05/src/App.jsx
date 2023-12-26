import { useEffect, useState } from "react";

function UrlTest() {
  const [user, setUser] = useState([]);
  const [searchTxt, setSearchTxt] = useState("");

  useEffect(() => {
    const URL = `https://www.melivecode.com/api/users?search=${searchTxt}`;

    fetch(URL)
      .then((res) => res.json())
      .then((response) => {
        setUser(response);
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
      });
  }, [searchTxt]);

  const handleSearchTxt = (e) => {
    setSearchTxt(e.target.value);
  };

  return (
    <>
      <div>
        <input
          type="text"
          value={searchTxt}
          onChange={handleSearchTxt}
          placeholder="search for names here"
        />
        {user.map((userData) => (
          <div key={userData.id}>
            <img src={userData.avatar} alt={userData.lastName} width={50} />
            {userData.firstName} {userData.lastName}
          </div>
        ))}
      </div>
    </>
  );
}

export default UrlTest;
