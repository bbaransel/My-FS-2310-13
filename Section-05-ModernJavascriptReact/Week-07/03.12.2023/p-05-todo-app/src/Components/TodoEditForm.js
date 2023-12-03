import React, { useState } from 'react'

const TodoEditForm = ({ task, saveTodo }) => {
    const [value, SetValue] = useState(task.desc);
    const handleSubmit = (e) => {
        e.preventDefault();
        saveTodo(task.id, value);
    }

    return (
        <>
            <form onSubmit={handleSubmit} className='TodoForm'>
                <input className='TodoInput' placeholder='Update task' type="text" value={value} onChange={(e) => { SetValue(e.target.value) }} />
                <button className='TodoBtn SaveBtn' type='Submit' >Save task</button>
            </form>
        </>
    )
}

export default TodoEditForm;