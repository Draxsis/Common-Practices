import React, { useState } from 'react';

function App() {
  const marginStyle = "10px";
  const [hoveredIndex, setHoveredIndex] = useState(null);

  const handleMouseEnter = (index) => {
    setHoveredIndex(index);
  };

  const handleMouseLeave = () => {
    setHoveredIndex(null);
  };

  return (
    <>
      <div style={{ display: "flex" }}>
        {[1, 2, 3, 4, 5].map((item, index) => (-
          <div
            key={index}
            style={{
              fontSize: "24px",
              margin: marginStyle,
              color: hoveredIndex !== null && index <= hoveredIndex ? 'Blue' : 'green',
              cursor: 'pointer',
            }}
            onMouseEnter={() => handleMouseEnter(index)}
            onMouseLeave={handleMouseLeave}
          >
            &#9733; 
          </div>
        ))}
      </div>
    </>
  );
}

export default App;
