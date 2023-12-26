import React from "react";
import ReactDOM from "react-dom/client";
import Display from "./Display";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <React.StrictMode>
    <Display color="purple" maxLength={20} />
  </React.StrictMode>
);
