import React, { useState } from 'react'

const TodoForm = ({ addTodo, todos }) => {
    const [value, setValue] = useState("");
    const handleSubmit = (e) => {
        e.preventDefault();
        if (value) {
            addTodo(value);
            console.log(value)
            setValue("");
            e.target.firstChild.focus()
        }
        console.log(todos);
    }
    return (
        <>
            <form onSubmit={handleSubmit} className='TodoForm'>
                <input onChange={(e) => { setValue(e.target.value); }} type="text" value={value} placeholder='What is the task today' className='TodoInput' />
                <button type='submit' className='TodoBtn'>Add Task</button>

            </form>
        </>
    )
}

export default TodoForm