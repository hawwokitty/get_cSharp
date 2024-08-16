import TodoItem from "./TodoItem";

function TodoList(props) {
    const items = props.tasks;
    const toggleTask = props.toggleTask;
    const deleteTask = props.deleteTask;

    return items.map((item, index) => {
        return <TodoItem key={index} item={item} toggleTask={toggleTask} deleteTask={deleteTask} />;
    });
}

export default TodoList;
