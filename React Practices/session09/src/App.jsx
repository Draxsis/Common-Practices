import Users from "./components/Users";
import Home from "./components/Home";
import About from "./components/About";
import { BrowserRouter, Route, Routes, NavLink } from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
      <div style={{ height: "600px", width: "100%" }}>
        <div
          style={{
            height: "100px",
            width: "100px",
            gap: "20",
            display: "flex",
          }}
        >
          <NavLink to="/" style={{ marginRight: 20 }}>
            Home
          </NavLink>
          <NavLink to="about" style={{ marginRight: 20 }}>
            About
          </NavLink>
          <NavLink to="users">Users</NavLink>
        </div>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="about" element={<About />} />
          <Route path="users" element={<Users />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
