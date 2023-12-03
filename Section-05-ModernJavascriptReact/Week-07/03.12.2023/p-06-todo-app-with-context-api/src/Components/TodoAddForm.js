import React, { useContext, useState } from 'react'
import { TodoContext } from '../Contexts/TodoContext';

const TodoAddForm = () => {
    const context = useContext(TodoContext);
    const [desc, setDesc] = useState("");
    const handleSubmit = (e) => {
        e.preventDefault();
        if (desc) {
            context.addTask(desc);
            setDesc("");
            e.target.firstChild.firstChild.focus()
        } else { alert("Please enter task") };
    };


    return (
        <div className='container g-0'>
            <h1 className='display-5 text-center mb-5 text-danger'>Todo App</h1>
            <form onSubmit={handleSubmit}>
                <div className="input-group mb-3">
                    <input onChange={(e) => { setDesc(e.target.value) }} value={desc} type="text" className="form-control" placeholder="Enter your task" aria-label="Enter your task" aria-describedby="button-addon2" />
                    <button className="btn btn-outline-success" type="submit" id="btn-add-task">Add Task</button>
                </div>
            </form>
        </div>
    )
}

export default TodoAddForm