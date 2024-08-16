import TodoList from "./components/TodoList";
import React, { useState, useRef } from "react";

function App() {
    const [listOfTasks, setList] = useState([]);
    const todoDescRef = useRef();

    function handleAdd(e) {
        const task = todoDescRef.current.value;

        if (task === "") return;
        setList((prevTask) => {
            return [
                ...prevTask,
                { id: listOfTasks.length, desc: task, complete: false },
            ];
        });
        todoDescRef.current.value = "";
    }

    function toggleTask(id) {
        const newTasks = [...listOfTasks];
        const task = newTasks.find((task) => task.id === id);
        task.complete = !task.complete;
        setList(newTasks);
    }

    function deleteTask(id) {
        const newTasks = [...listOfTasks];
        const index = newTasks.findIndex((task) => task.id === id);
        newTasks.splice(index, 1);
        setList(newTasks);
    }

    return (
        <div>
            <div className="input-group flex-nowrap">
                <span className="input-group-text" id="addon-wrapping">
                    Add task:
                </span>
                <input
                    ref={todoDescRef}
                    id="inputTask"
                    type="text"
                    className="form-control"
                    placeholder="Clean kitchen"
                    aria-describedby="addon-wrapping"
                />
                <button type="button" className="btn btn-light" onClick={handleAdd}>
                    Add
                </button>
            </div>
            <h1>To Do List</h1>
            <TodoList tasks={listOfTasks} toggleTask={toggleTask} deleteTask={deleteTask} />
        </div>
    );
}

export default App;
