const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

function perguntar(pergunta) {
    return new Promise((resolve) => {
        rl.question(pergunta, resolve);
    });
}

function mostrarMenuPrincipal() {
    console.log("\n" + "=".repeat(50));
    console.log("         CALCULADORA CIENTÍFICA (JavaScript)");
    console.log("=".repeat(50));
    console.log("1. Operações Básicas");
    console.log("2. Potência e Raízes");
    console.log("3. Trigonometria");
    console.log("4. Logaritmos");
    console.log("5. Números Complexos");
    console.log("0. Sair");
    console.log("=".repeat(50));
}

async function menuBasicas() {
    let opcao;
    do {
        console.clear();
        console.log("--- OPERAÇÕES BÁSICAS ---");
        console.log("1. Adição");
        console.log("2. Subtração");
        console.log("3. Multiplicação");
        console.log("4. Divisão");
        console.log("0. Voltar");
        
        opcao = await perguntar("Escolha: ");
        
        if (opcao === '1') {
            let num1 = parseFloat(await perguntar("Digite o primeiro número: "));
            let num2 = parseFloat(await perguntar("Digite o segundo número: "));
            console.log(`Resultado: ${num1} + ${num2} = ${num1 + num2}`);
        } else if (opcao === '2') {
            let num1 = parseFloat(await perguntar("Digite o primeiro número: "));
            let num2 = parseFloat(await perguntar("Digite o segundo número: "));
            console.log(`Resultado: ${num1} - ${num2} = ${num1 - num2}`);
        } else if (opcao === '3') {
            let num1 = parseFloat(await perguntar("Digite o primeiro número: "));
            let num2 = parseFloat(await perguntar("Digite o segundo número: "));
            console.log(`Resultado: ${num1} × ${num2} = ${num1 * num2}`);
        } else if (opcao === '4') {
            let num1 = parseFloat(await perguntar("Digite o primeiro número: "));
            let num2 = parseFloat(await perguntar("Digite o segundo número: "));
            if (num2 === 0) {
                console.log("Erro: Divisão por zero não permitida!");
            } else {
                console.log(`Resultado: ${num1} ÷ ${num2} = ${num1 / num2}`);
            }
        }
        
        if (opcao !== '0') {
            await perguntar("\nPressione Enter para continuar...");
        }
    } while (opcao !== '0');
}

async function menuPotenciaRaiz() {
    let opcao;
    do {
        console.clear();
        console.log("--- POTÊNCIA E RAÍZES ---");
        console.log("1. Potência (x^y)");
        console.log("2. Raiz Quadrada");
        console.log("3. Raiz Cúbica");
        console.log("0. Voltar");
        
        opcao = await perguntar("Escolha: ");
        
        if (opcao === '1') {
            let base = parseFloat(await perguntar("Digite a base: "));
            let expoente = parseFloat(await perguntar("Digite o expoente: "));
            console.log(`Resultado: ${base}^${expoente} = ${Math.pow(base, expoente)}`);
        } else if (opcao === '2') {
            let numero = parseFloat(await perguntar("Digite o número: "));
            if (numero < 0) {
                console.log("Erro: Raiz quadrada de número negativo não é real!");
            } else {
                console.log(`Resultado: √${numero} = ${Math.sqrt(numero)}`);
            }
        } else if (opcao === '3') {
            let numero = parseFloat(await perguntar("Digite o número: "));
            if (numero < 0) {
                console.log(`Resultado: ∛${numero} = -${Math.pow(-numero, 1/3)}`);
            } else {
                console.log(`Resultado: ∛${numero} = ${Math.pow(numero, 1/3)}`);
            }
        }
        
        if (opcao !== '0') {
            await perguntar("\nPressione Enter para continuar...");
        }
    } while (opcao !== '0');
}

async function menuTrigonometria() {
    let opcao;
    do {
        console.clear();
        console.log("--- TRIGONOMETRIA ---");
        console.log("1. Seno");
        console.log("2. Cosseno");
        console.log("3. Tangente");
        console.log("4. Arco Seno");
        console.log("5. Arco Cosseno");
        console.log("6. Arco Tangente");
        console.log("0. Voltar");
        
        opcao = await perguntar("Escolha: ");
        
        if (opcao === '1') {
            let angulo = parseFloat(await perguntar("Digite o ângulo em graus: "));
            let radianos = angulo * Math.PI / 180;
            console.log(`sen(${angulo}°) = ${Math.sin(radianos).toFixed(4)}`);
        } else if (opcao === '2') {
            let angulo = parseFloat(await perguntar("Digite o ângulo em graus: "));
            let radianos = angulo * Math.PI / 180;
            console.log(`cos(${angulo}°) = ${Math.cos(radianos).toFixed(4)}`);
        } else if (opcao === '3') {
            let angulo = parseFloat(await perguntar("Digite o ângulo em graus: "));
            let radianos = angulo * Math.PI / 180;
            console.log(`tan(${angulo}°) = ${Math.tan(radianos).toFixed(4)}`);
        } else if (opcao === '4') {
            let valor = parseFloat(await perguntar("Digite o valor (entre -1 e 1): "));
            if (valor >= -1 && valor <= 1) {
                console.log(`arcsen(${valor}) = ${(Math.asin(valor) * 180 / Math.PI).toFixed(2)}°`);
            } else {
                console.log("Erro: Valor fora do domínio (-1 a 1)");
            }
        } else if (opcao === '5') {
            let valor = parseFloat(await perguntar("Digite o valor (entre -1 e 1): "));
            if (valor >= -1 && valor <= 1) {
                console.log(`arccos(${valor}) = ${(Math.acos(valor) * 180 / Math.PI).toFixed(2)}°`);
            } else {
                console.log("Erro: Valor fora do domínio (-1 a 1)");
            }
        } else if (opcao === '6') {
            let valor = parseFloat(await perguntar("Digite o valor: "));
            console.log(`arctan(${valor}) = ${(Math.atan(valor) * 180 / Math.PI).toFixed(2)}°`);
        }
        
        if (opcao !== '0') {
            await perguntar("\nPressione Enter para continuar...");
        }
    } while (opcao !== '0');
}

async function menuLogaritmos() {
    let opcao;
    do {
        console.clear();
        console.log("--- LOGARITMOS ---");
        console.log("1. Logaritmo Natural (ln)");
        console.log("2. Logaritmo Base 10 (log10)");
        console.log("3. Logaritmo em qualquer base");
        console.log("0. Voltar");
        
        opcao = await perguntar("Escolha: ");
        
        if (opcao === '1') {
            let numero = parseFloat(await perguntar("Digite o número: "));
            if (numero <= 0) {
                console.log("Erro: Logaritmo de número não positivo!");
            } else {
                console.log(`ln(${numero}) = ${Math.log(numero).toFixed(4)}`);
            }
        } else if (opcao === '2') {
            let numero = parseFloat(await perguntar("Digite o número: "));
            if (numero <= 0) {
                console.log("Erro: Logaritmo de número não positivo!");
            } else {
                console.log(`log10(${numero}) = ${Math.log10(numero).toFixed(4)}`);
            }
        } else if (opcao === '3') {
            let numero = parseFloat(await perguntar("Digite o número: "));
            let base = parseFloat(await perguntar("Digite a base: "));
            if (numero <= 0 || base <= 0 || base === 1) {
                console.log("Erro: Parâmetros inválidos!");
            } else {
                console.log(`log${base}(${numero}) = ${(Math.log(numero) / Math.log(base)).toFixed(4)}`);
            }
        }
        
        if (opcao !== '0') {
            await perguntar("\nPressione Enter para continuar...");
        }
    } while (opcao !== '0');
}

async function menuComplexos() {
    let opcao;
    do {
        console.clear();
        console.log("--- NÚMEROS COMPLEXOS ---");
        console.log("1. Adição");
        console.log("2. Multiplicação");
        console.log("3. Módulo");
        console.log("4. Forma Polar");
        console.log("0. Voltar");
        
        opcao = await perguntar("Escolha: ");
        
        if (opcao === '1') {
            let real1 = parseFloat(await perguntar("Parte real do primeiro: "));
            let imag1 = parseFloat(await perguntar("Parte imaginária do primeiro: "));
            let real2 = parseFloat(await perguntar("Parte real do segundo: "));
            let imag2 = parseFloat(await perguntar("Parte imaginária do segundo: "));
            console.log(`Resultado: (${real1} + ${imag1}i) + (${real2} + ${imag2}i) = ${real1 + real2} + ${imag1 + imag2}i`);
        } else if (opcao === '2') {
            let real1 = parseFloat(await perguntar("Parte real do primeiro: "));
            let imag1 = parseFloat(await perguntar("Parte imaginária do primeiro: "));
            let real2 = parseFloat(await perguntar("Parte real do segundo: "));
            let imag2 = parseFloat(await perguntar("Parte imaginária do segundo: "));
            let real = real1 * real2 - imag1 * imag2;
            let imag = real1 * imag2 + imag1 * real2;
            console.log(`Resultado: (${real1} + ${imag1}i) × (${real2} + ${imag2}i) = ${real} + ${imag}i`);
        } else if (opcao === '3') {
            let real = parseFloat(await perguntar("Parte real: "));
            let imag = parseFloat(await perguntar("Parte imaginária: "));
            let modulo = Math.sqrt(real * real + imag * imag);
            console.log(`Módulo de ${real} + ${imag}i = ${modulo.toFixed(4)}`);
        } else if (opcao === '4') {
            let real = parseFloat(await perguntar("Parte real: "));
            let imag = parseFloat(await perguntar("Parte imaginária: "));
            let modulo = Math.sqrt(real * real + imag * imag);
            let fase = Math.atan2(imag, real) * 180 / Math.PI;
            console.log(`Forma polar: ${modulo.toFixed(4)} ∠ ${fase.toFixed(2)}°`);
        }
        
        if (opcao !== '0') {
            await perguntar("\nPressione Enter para continuar...");
        }
    } while (opcao !== '0');
}

async function main() {
    let opcao;
    do {
        console.clear();
        mostrarMenuPrincipal();
        opcao = await perguntar("Escolha uma opção: ");
        
        if (opcao === '1') {
            await menuBasicas();
        } else if (opcao === '2') {
            await menuPotenciaRaiz();
        } else if (opcao === '3') {
            await menuTrigonometria();
        } else if (opcao === '4') {
            await menuLogaritmos();
        } else if (opcao === '5') {
            await menuComplexos();
        } else if (opcao === '0') {
            console.log("\nSaindo... Obrigado por usar a calculadora!");
        } else {
            console.log("Opção inválida!");
            await perguntar("Pressione Enter para continuar...");
        }
    } while (opcao !== '0');
    
    rl.close();
}

main();