import React, { useEffect, useState } from 'react';
import service from './service.js';
import './App.css'; // Import the CSS file

function App() {
  const [newTodo, setNewTodo] = useState("");
  const [todos, setTodos] = useState([]);

  async function getTodos() {
    const todos = await service.getItems();
    setTodos(todos);
  }

  async function createTodo(e) {
    e.preventDefault();
    await service.addItem(newTodo);
    setNewTodo(""); // Clear input
    await getTodos(); // Refresh tasks list
  }

  async function updateCompleted(todo, isComplete) {
    await service.setItemCompleted(todo.id, isComplete);
    await getTodos(); // Refresh tasks list
  }

  async function deleteTodo(id) {
    await service.deleteItem(id);
    await getTodos(); // Refresh tasks list
  }

  useEffect(() => {
    getTodos();
  }, []);

  return (
    <section className="todoapp">
      <header className="header">
        <h1>todos</h1>
        <form onSubmit={createTodo}>
          <input 
            className="new-todo" 
            placeholder="Well, let's take on the day" 
            value={newTodo} 
            onChange={(e) => setNewTodo(e.target.value)} 
          />
        </form>
      </header>
      <section className="main" style={{ display: "block" }}>
        <ul className="todo-list">
          {todos.map(todo => {
            return (
              <li className={todo.isComplete ? "completed" : ""} key={todo.id}>
                <div className="view">
                  <input 
                    className="toggle" 
                    type="checkbox" 
                    checked={todo.isComplete} 
                    onChange={(e) => updateCompleted(todo, e.target.checked)} 
                  />
                  <label className={todo.isComplete ? "completed-label" : ""}>
                    {todo.name}
                  </label>
                  <button className="destroy" onClick={() => deleteTodo(todo.id)}></button>
                </div>
              </li>
            );
          })}
        </ul>
      </section>
    </section>
  );
}

export default App;