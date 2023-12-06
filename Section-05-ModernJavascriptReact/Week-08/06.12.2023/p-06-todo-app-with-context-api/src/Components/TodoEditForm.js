import React, { useContext, useState } from 'react'
import { TodoContext } from '../Contexts/TodoContext';

const TodoEditForm = ({ task }) => {
    const context = useContext(TodoContext);
    const [desc, setDesc] = useState(task.desc);
    const handleSubmit = (e) => {
        e.preventDefault();
        if (desc) {
            context.updateTask(task.id, desc);
        } else { alert("Please enter task") };
    };


    return (
        <form onSubmit={handleSubmit}>
            <div className="input-group mb-3">
                <input onChange={(e) => { setDesc(e.target.value) }} value={desc} type="text" className="form-control bg-light" placeholder="update your task" aria-label="Update your task" aria-describedby="button-addon2" />
                <button className="btn btn-warning" type="submit" id="btn-add-task" >Update Task</button>
            </div>
        </form>
    )
}

export default TodoEditForm