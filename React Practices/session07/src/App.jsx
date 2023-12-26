import { useReducer} from "react";
import { initialState, Reducer } from "./Reducer";

// main App 
export default function App() {
  const [state, dispatch] = useReducer(Reducer, initialState);

  // Handlers
  const handleAdd = () => {
    dispatch({ type: "ADD_TASK" });
  };
  const handleDeleteClick = (task) => {
    dispatch({ type: "DELETE_TASK", payload: task });
  };
  const handleToggleTask = (task) => {
    dispatch({ type: "TOGGLE_TASK", payload: task });
  };
  const handleNewTextChange = (e) => {
    dispatch({ type: "UPDATE_NEW_TEXT", payload: e.target.value });
  };

  // JSX
  return (
    <>
      <input
        type="text"
        placeholder="write it down"
        value={state.newText}
        onChange={handleNewTextChange}
      />
      <button onClick={handleAdd}>Add</button>
      <ul>
        {state.tasks.map((task) => (
          <li
            key={task.title}
            style={{ textDecoration: task.done ? "line-through" : "none" }}
          >
            <input
              type="checkbox"
              checked={task.done}
              onChange={() => handleToggleTask(task)}
            />
            <button onClick={() => handleDeleteClick(task)}>X</button>
            {task.title}
          </li>
        ))}
      </ul>
    </>
  );
}
