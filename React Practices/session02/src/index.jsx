import React from "react";
import ReactDOM from "react-dom/client";
import Counter from "./Counter";
import CounterSecondary from "./CounterSecond";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
    <Counter label={"First label by Props"} />
    <Counter label={"Secondary label by Props"} />
    <CounterSecondary label={"Add +5 "}  />
    <CounterSecondary label={"Minus -5 "}   />
  </React.StrictMode>
);
