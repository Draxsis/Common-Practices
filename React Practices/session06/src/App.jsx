import React, { useState, useEffect } from "react";

export default function Todo() {
  const [tasks, setTasks] = useState(() => {
    const storedTasks = localStorage.getItem("tasks");
    
    return storedTasks ? JSON.parse(storedTasks): [
          { title: "test1", done: false },
          { title: "test2", done: false },
          { title: "test3", done: false },
        ];
  });

  const [newText, setNewText] = useState("");

  const handleAdd = () => {
    const updatedTasks = [...tasks, { title: newText, done: false }];
    setTasks(updatedTasks);
    setNewText("");
  };

  const handleCheckboxChange = (index) => {
    const updatedTasks = [...tasks];
    updatedTasks[index].done = !updatedTasks[index].done;
    setTasks(updatedTasks);
  };

  const handleDelete = (index) => {
    const updatedTasks = [...tasks];
    updatedTasks.splice(index, 1);
    setTasks(updatedTasks);
  };

  useEffect(() => {
    localStorage.setItem("tasks", JSON.stringify(tasks));
  }, [tasks]);

  return (
    <>
      <input
        type="text"
        placeholder="add here"
        onChange={(e) => setNewText(e.target.value)}
        value={newText}
      />
      <button onClick={handleAdd} style={{ marginLeft: "10px" }}>
        Add
      </button>
      <div style={{ border: "1px solid transparent " }}>
        {tasks.map((task, index) => (
          <div
            key={index}
            style={{
              display: "flex",
              alignItems: "center",
              justifyContent: "space-between",
              width: "180px",
              border: "1px solid gray",
              marginTop: "10px",
              textAlign: "left",
            }}
          >
            <div>
              <input
                type="checkbox"
                checked={task.done}
                onChange={() => handleCheckboxChange(index)}
              />
              {task.title}
            </div>
            <button onClick={() => handleDelete(index)}>Delete</button>
          </div>
        ))}
      </div>
    </>
  );
}
